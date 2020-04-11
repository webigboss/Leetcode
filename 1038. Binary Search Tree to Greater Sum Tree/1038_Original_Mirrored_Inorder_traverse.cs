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
    public TreeNode BstToGst(TreeNode root) {
        //mirroed inorder traversal to make sure traverse from the bigger to smaller
        Helper(root, 0);
        return root;
    }
    
    private int Helper(TreeNode node, int sum){
        if(node == null) return sum;
        sum = Helper(node.right, sum);
        sum += node.val;
        node.val = sum;
        sum = Helper(node.left, sum);
        return sum;
    }  
}