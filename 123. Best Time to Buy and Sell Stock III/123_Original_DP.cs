public class Solution {
    public int MaxProfit(int[] prices) {
        // DP solutions
        // k: transactions; i: day
        // DP pattern: dp[k, i] = max(dp[k, i - 1],  prices[i] -  min(for j = 1 to i  (prices[j] - dp[k - 1, j - 1]))) 
        //https://leetcode.com/problems/best-time-to-buy-and-sell-stock-iii/discuss/135704/Detail-explanation-of-DP-solution
        if(prices.Length == 0)
            return 0;
        var dp = new int[3, prices.Length];
        
        for(var k = 1; k <= 2; k++){
            var min = prices[0];
            for(var i = 1; i < prices.Length; i++){
                min = Math.Min(prices[i] - dp[k - 1, i - 1], min);
                dp[k, i] = Math.Max(dp[k, i - 1], prices[i] - min);
            }
        }
        return dp[2, prices.Length - 1];
    }
}