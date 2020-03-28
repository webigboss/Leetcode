public class Solution {
    public int Change(int amount, int[] coins) {
        if(amount == 0) return 1;
        //complete knapsack problem
        var dp = new int[coins.Length + 1][];
        for(var i = 0; i <= coins.Length; ++i)
            dp[i] = new int[amount + 1];
        //base case dp[i][0] = 1; 
        //amount = 5, coins = [1, 2, 5], think about 5 = 5, meaning dp[3,5] = dp[2, 5] + dp[2,0] = dp[2,5] + 1;
        for(var i = 1; i <= coins.Length; ++i){
            dp[i][0] = 1;
            for(var j = 1; j <= amount; ++j){
                dp[i][j] = dp[i-1][j] + (j >= coins[i-1] ? dp[i][j-coins[i-1]] : 0); //it's dp[i][j-coins[i-1]] because we can reuse same coin
            }
        }
        return dp[coins.Length][amount];
    }
}