/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int PseudoPalindromicPaths (TreeNode root) {
        var cnts = new int[10];
        return Helper(root, cnts);
    }
    
    int Helper(TreeNode node, int[] cnts){
        cnts[node.val]++;
        var ans = 0;
        if(node.left == null && node.right == null){
            if(IsP(cnts)) ans = 1;
            else ans = 0;
            cnts[node.val]--;
            return ans;
        }

        if(node.left != null){
            ans += Helper(node.left, cnts);
        }
        if(node.right != null){
            ans+= Helper(node.right, cnts);
        }
        cnts[node.val]--;
        return ans;
    }
    
    bool IsP(int[] cnts){
        // for(var i = 1; i < 10; ++i){
        //     Console.Write($"{i}->{cnts[i]},");    
        // }
        // Console.Write("\n");
        bool foundOdd = false, hasValue = false;
        for(var i = 1; i < 10; ++i){
            if(cnts[i] > 0) hasValue = true;
            if(cnts[i] % 2 == 1) {
                if(foundOdd) return false;
                foundOdd = true;
            }
        }
        return hasValue;
    }
}