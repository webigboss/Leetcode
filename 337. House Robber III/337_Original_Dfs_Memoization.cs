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
    public int Rob(TreeNode root) {
        //Dfs with memoization optimization to reduce recursions call to twice on each treenode
        //int[0] max money can be robbed when robbing current node, int[1] max money can be robbed when skipping current node
        var memo = new Dictionary<TreeNode, int[]>();
        return RobDfsHelper(root, false, memo);
    }
    
    private int RobDfsHelper(TreeNode node, bool isParentRobbed, IDictionary<TreeNode, int[]> memo){
        if(node == null) return 0;
        
        if(isParentRobbed){ // parent was robbed, so cur node must not be robbed, just return the non robbed logic;
            if(memo.ContainsKey(node) && memo[node][1] != 0)
                return memo[node][1];
            var money = RobDfsHelper(node.left, false, memo) + RobDfsHelper(node.right, false, memo);
            if(memo.ContainsKey(node))
                memo[node][1] = money;
            else{
                memo[node] = new int[]{0, money};
            }
            return money;
        }
        else{ // parent was not robbed, so cur node can be either robbed or skipped, just return the max of these 2 cases.
            int money1 = 0;
            int money2 = 0;
            if(memo.ContainsKey(node)){
                money1 = memo[node][0];
                money2 = memo[node][1];
            }
            
            if(money1 == 0){
                money1 = node.val + RobDfsHelper(node.left, true, memo) + RobDfsHelper(node.right, true, memo);
                if(memo.ContainsKey(node))
                    memo[node][0] = money1;
                else
                    memo[node] = new int[]{money1, 0};
            }
            if(money2 == 0){
                money2 = RobDfsHelper(node.left, false, memo) + RobDfsHelper(node.right, false, memo);
                if(memo.ContainsKey(node))
                    memo[node][1] = money2;
                else
                    memo[node] = new int[]{0, money2};
            }          
            return Math.Max(money1, money2);
        }
    }
}