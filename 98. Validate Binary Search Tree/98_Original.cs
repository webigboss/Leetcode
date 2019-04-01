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
    public bool IsValidBST(TreeNode root) {
        var inOrderList = new List<int>();
    }
    
    private void InorderTraversal(TreeNode n, List<int> list){
        if(n == null)
            return false;
        
        InorderTraversal(n.left, list);
        list.Add(n.val);
        InorderTraversal(n.right, list);
    }
}