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
    public int DiameterOfBinaryTree(TreeNode root) {
        if(root == null) return 0;
        //GetHeight(root.left) - 1 + GetHeight(root.right) - 1 + 2. because we are calculating the length between nodes;
        var diameterOfCurrentNode = GetHeight(root.left) + GetHeight(root.right);
        return Math.Max(diameterOfCurrentNode, 
                        Math.Max(DiameterOfBinaryTree(root.left), DiameterOfBinaryTree(root.right)));
    }
    
    public int GetHeight(TreeNode node){
        if(node == null) return 0;
        return Math.Max(GetHeight(node.left), GetHeight(node.right)) + 1;
    }
}