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
    public IList<TreeNode> GenerateTrees(int n) {
        if(n == 0)
            return new List<TreeNode>();
        var dp = new List<TreeNode>[n + 1];
        
        dp[0] = new List<TreeNode>{ null };
        dp[1] = new List<TreeNode>{ new TreeNode(1) };
        
        for(var i = 2; i <= n; i++){
            dp[i] = new List<TreeNode>();
            for(var j = 1; j <= i; j++){
                foreach(var left in dp[j - 1]){
                    foreach(var right in dp[i - j]){
                        var root = new TreeNode(j);
                        root.left = left;
                        root.right = ClonebyOffset(right, j);
                        dp[i].Add(root);
                    }
                }
            }
        }
        return dp[n];
    }
    
    private TreeNode ClonebyOffset(TreeNode n, int offset){
        if(n == null){
            return null;
        }
        var clone = new TreeNode(n.val + offset);
        clone.left = ClonebyOffset(n.left, offset);
        clone.right = ClonebyOffset(n.right, offset);
        return clone;
    }
}