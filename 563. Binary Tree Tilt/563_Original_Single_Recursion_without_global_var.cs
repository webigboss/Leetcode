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
    public int FindTilt(TreeNode root) {
        //optimize by removing nested recursion, and without global variable
        var result = new int[1];
        Helper(root, result);
        return result[0];
    }
    
    //calculate sum
    public int Helper(TreeNode node, int[] result){
        //postorder traverse, calculate the sum bottom up
        if(node == null) return 0;
        var leftSum = Helper(node.left, result);
        var rightSum = Helper(node.right, result);
        result[0] += Math.Abs(leftSum - rightSum);
        return leftSum + rightSum + node.val;
    }
}