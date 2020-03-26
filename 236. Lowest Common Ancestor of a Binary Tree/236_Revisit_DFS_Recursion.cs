/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

//the revisit solution adjusted the logical order by 
//bring the check for root ==p and root = q at the beginning of the method, 
//which will elimiate unnecessary recursion make it more optimized;
public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(root == q || root == p || root == null) 
            return root;
        
        var left = LowestCommonAncestor(root.left, p, q);
        var right = LowestCommonAncestor(root.right, p, q);
        
        if(left != null && right != null) return root;
        return left ?? right;
        
    }
}