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
        
        if(root == null) return 0;
        var result = Math.Abs(CalculateSum(root.left) - CalculateSum(root.right));
        return result + FindTilt(root.left) + FindTilt(root.right); 
    }
    
    private int CalculateSum(TreeNode node){
        if(node == null) return 0;
        return node.val + CalculateSum(node.left) + CalculateSum(node.right);
    }
}