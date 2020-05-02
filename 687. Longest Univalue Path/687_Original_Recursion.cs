public class Solution {
    public int LongestUnivaluePath(TreeNode root) {
        if(root == null) return 0;
        var ans = MaxHeight(root.left, root.val) + MaxHeight(root.right, root.val);
        var left = LongestUnivaluePath(root.left);
        var right = LongestUnivaluePath(root.right);
        ans = Math.Max(ans, Math.Max(left, right));
        return ans;
    }
    
    private int MaxHeight(TreeNode root, int val){
        if(root == null || root.val != val) return 0;
        var ans = 1;
        
        var left = MaxHeight(root.left, val);
        var right = MaxHeight(root.right, val);
        return ans + Math.Max(left, right);
    }

}
