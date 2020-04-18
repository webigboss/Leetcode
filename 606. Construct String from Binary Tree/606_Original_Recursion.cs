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
    public string Tree2str(TreeNode t) {
        if(t == null) return string.Empty;
        
        var left = Tree2str(t.left);
        var right = Tree2str(t.right);
        if(string.IsNullOrEmpty(left) && string.IsNullOrEmpty(right))
            return t.val.ToString();
        if(string.IsNullOrEmpty(right))
            return t.val.ToString() + "(" + left + ")";
        else
            return t.val.ToString() + "(" + left + ")" + "(" + right + ")";
    }
}