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
    public void Flatten(TreeNode root) {
        if(root == null)
            return;
        var flathead = new TreeNode(0);
        var current = flathead;
        FlattenRecursive(root, ref current);
        root.right = flathead.right.right;
        root.left = null;
        //root = flathead.right;
    }
    
    private void FlattenRecursive(TreeNode n, ref TreeNode current){
        //preorder recursion
        if(n == null)
            return;
        
        current.right = new TreeNode(n.val);
        current = current.right;
        
        FlattenRecursive(n.left, ref current);
        FlattenRecursive(n.right, ref current);
    }
}