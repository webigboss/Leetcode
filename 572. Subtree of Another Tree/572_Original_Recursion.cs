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
    public bool IsSubtree(TreeNode s, TreeNode t) {
        if(s == null) return false;
        return IsSame(s, t) || IsSubtree(s.left, t) || IsSubtree(s.right, t);
    }
    
    private bool IsSame(TreeNode a, TreeNode b){
        if(a == null && b == null) return true;
        if(a == null && b != null || a != null && b == null) return false;
        
        return a.val == b.val && IsSame(a.left, b.left) && IsSame(a.right, b.right);
    }
}