public class Solution {
    public int MaxProfit(int[] prices, int fee) {
        var n = prices.Length; 
//         var dp = new int[n, 2];
//         //base case
//         dp[0, 0] = 0;
//         dp[0, 1] = -prices[0]-2;
        
//         for(var i = 1; i <= n; ++i){
//             dp[i, 0] = dp[i-1, 0];
//             dp[i, 1] = dp[i-1, 1];
//             for(var j = 0; j < i; ++j){
//                 dp[i, 0] = Math.Max(dp[i, 0], dp[j, 1] + prices[i]);
//                 dp[i, 1] = Math.Max(dp[i, 1], dp[j, 0] - prices[i] - 2);
//             }
//         }
        var dp = new int[2];
        //base case 
        dp[0] = 0;
        dp[1] = -prices[0]-fee;
        
        for(var i = 1; i < n; ++i){
            var newdp = new int[2];
            newdp[0] = Math.Max(dp[0], dp[1] + prices[i]);
            newdp[1] = Math.Max(dp[1], dp[0] - prices[i] - fee);
            dp = newdp;
        }
        return Math.Max(dp[0], dp[1]);
    }
}