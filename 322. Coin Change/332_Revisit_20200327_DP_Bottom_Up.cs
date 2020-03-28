public class Solution {
    public int CoinChange(int[] coins, int amount) {
        //complete knapsack problem: dp[i, j], i: use first ith coin, 
        //j: the amount as the weight in the original problem
        //the dp array's value will be the minimum count of coins needed to get the give amount
        var dp = new int[amount + 1];
        //base case
        Array.Fill(dp, amount + 1); //the populate a value that is certainly greater than the answer
        dp[0] = 0; // if target 
        for(var i = 0; i < coins.Length; ++i){
            for(var j = coins[i]; j <= amount; ++j){
                dp[j] = Math.Min(dp[j], dp[j - coins[i]] + 1);
            }
        }
        return dp[amount] == amount + 1 ? -1 : dp[amount];
    }
}