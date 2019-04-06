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
    public int CountNodes(TreeNode root) {
        //Trivial Recursive solution
        var count = 0;
        CountNodesRecursive(root, ref count);
        return count;
    }
    
    public void CountNodesRecursive(TreeNode n, ref int count){
        if(n == null)
            return;
        count++;
        CountNodesRecursive(n.left, ref count);
        CountNodesRecursive(n.right, ref count);
    }
}