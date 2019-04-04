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
    public IList<int> PreorderTraversal(TreeNode root) {
        //recursive solution
        var list = new List<int>();
        PreorderTraversalRecursive(root, list);
        return list;
    }
    
    private void PreorderTraversalRecursive(TreeNode n, List<int> list){
        if(n == null)
            return;
        
        list.Add(n.val);
        PreorderTraversalRecursive(n.left, list);
        PreorderTraversalRecursive(n.right, list);
    }
}