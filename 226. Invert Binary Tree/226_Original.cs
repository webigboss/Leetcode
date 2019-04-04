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
    public TreeNode InvertTree(TreeNode root) {
        root = InvertTreeRecursive(root);
        return root;
    }
    
    private TreeNode InvertTreeRecursive(TreeNode n){
        if(n == null)
            return null;
        
        var templeft = n.left;
        n.left = InvertTreeRecursive(n.right);
        n.right = InvertTreeRecursive(templeft);
        return n;
    }
}