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
    public bool IsBalanced(TreeNode root) {
        if(root == null)
            return true;
        
        var ldepth = GetDepthRecursively(root.left, 1);
        var rdepth = GetDepthRecursively(root.right, 1);
        return Math.Abs(ldepth - rdepth) <= 1 && IsBalanced(root.left) && IsBalanced(root.right);
    }

    private int GetDepthRecursively(TreeNode n, int depth){
        if(n == null)
            return depth;
        depth++;
        return Math.Max(GetDepthRecursively(n.left, depth), GetDepthRecursively(n.right, depth));
    }
}