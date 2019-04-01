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
    public bool HasPathSum(TreeNode root, int sum) {
        return HasPathSumRecursive(root, 0, sum);
    }
    
    private bool HasPathSumRecursive(TreeNode n, int parentSum, int targetSum){
        if(n == null)
            return false;
        
        if(n.left == null && n.right == null)
            return  n.val + parentSum == targetSum;
    
        return HasPathSumRecursive(n.left, parentSum + n.val, targetSum) || HasPathSumRecursive(n.right, parentSum + n.val, targetSum);
        
    }
}