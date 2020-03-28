using System;

namespace AlgorithmPlayground
{
    public class CoinChange
    {
        public CoinChange()
        {
            var coins = new[] { 1, 2, 5, };
            var amount = 11;
            var n = Solution(coins, amount);
        }
        public int Solution(int[] coins, int amount)
        {
            //complete knapsack problem: dp[i, j], i: use first ith coin, 
            //j: the amount as the weight in the original problem
            //the dp array's value will be the minimum count of coins needed to get the give amount
            var dp = new int[coins.Length + 1][];
            for (var i = 0; i < dp.Length; i++)
            {
                dp[i] = new int[amount + 1];
            }
            //base case
            for (var j = 1; j <= amount; ++j)
            {
                //assign a value that will be sure greater than any possible answer
                dp[0][j] = coins.Length + 1;
            }

            for (var i = 1; i < dp.Length; ++i)
            {
                for (var j = coins[i - 1]; j <= amount; ++j)
                {
                    dp[i][j] = Math.Min(dp[i - 1][j], dp[i - 1][j - coins[i - 1]] + 1);
                }
            }
            return dp[coins.Length][amount];
        }
    }
}