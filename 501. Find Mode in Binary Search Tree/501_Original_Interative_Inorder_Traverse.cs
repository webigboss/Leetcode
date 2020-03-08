/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public int[] FindMode(TreeNode root) {
        //interative inorder traversal
        if(root == null) return new int[0];
        var max = 0;
        var count = 1;
        var result = new List<int>();
        var list = new List<int>();
        var st = new Stack<TreeNode>();
        while(true){
            while(root != null){
                st.Push(root);
                root = root.left;
            }
            
            if(st.Count == 0)
                break;
            root = st.Pop();
            list.Add(root.val);
            root = root.right;
        }
        
        // result.Add(list[0]);
        
        for(var i = 0; i < list.Count; ++i){
            if(i > 0 && list[i] != list[i - 1]) {
               if(count > max){
                    result.Clear();
                    result.Add(list[i - 1]);
                    max = count;
                }
                else if(count == max)
                    result.Add(list[i - 1]);
                count = 1;
            }
            count++;
        }
        
        if(count > max){
            result.Clear();
            result.Add(list[list.Count - 1]);
        }
        else if(count == max)
            result.Add(list[list.Count - 1]);
        
        return result.ToArray();
    }
}