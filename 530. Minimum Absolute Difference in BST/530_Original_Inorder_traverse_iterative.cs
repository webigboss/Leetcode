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
    public int GetMinimumDifference(TreeNode root) {
        // inorder traverse iterative
        var list = InOrder(root);
        var minDiff = int.MaxValue;
        for(var i = 0; i < list.Count - 1; ++i){
            minDiff = Math.Min(minDiff, Math.Abs(list[i] - list[i + 1]));
        }
        return minDiff;
    }
    
    private IList<int> InOrder(TreeNode root){
        var list = new List<int>();
        var st = new Stack<TreeNode>();
        
        while(true){
            while(root != null){
                st.Push(root);
                root = root.left;
            }
            if(st.Count == 0) break;
            root = st.Pop();
            list.Add(root.val);
            root = root.right;
        }
        return list;
    }
}