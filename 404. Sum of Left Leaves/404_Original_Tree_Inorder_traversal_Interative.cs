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
    public int SumOfLeftLeaves(TreeNode root) {
        //interative DFS traversal using a stack
        var st = new Stack<TreeNode>();
        var sum = 0;
        
        while(true){
            while(root != null){    
                st.Push(root);
                root = root.left;
                
                if(root != null && root.left == null && root.right == null)
                    sum += root.val;
            }
            if(st.Count == 0) break;
            root = st.Pop().right;
        }
        return sum;
    }
}