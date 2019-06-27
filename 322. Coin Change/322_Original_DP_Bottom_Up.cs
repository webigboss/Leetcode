public class Solution {
    public int CoinChange(int[] coins, int amount) {
        if(amount == 0)
            return 0;
        var dp = new int[amount + 1];
        
        for(var i = 1; i <= amount; i++){
            int min = 0;
            for(var j = 0; j < coins.Length; j++){
                if(i % coins[j] == 0){
                    dp[i] = dp[i] == 0 ? i / coins[j] : Math.Min(dp[i], i / coins[j]);
                }
                if(i - coins[j] >= 1 && dp[i - coins[j]] != 0){
                    min = min == 0 ? dp[i - coins[j]] + 1 : Math.Min(min, dp[i - coins[j]] + 1);
                }
            }
            if(min != 0 && dp[i] != 0)
                dp[i] = Math.Min(min, dp[i]);
            else if(min != 0 && dp[i] == 0)
                dp[i] = min;
                
        }
        return dp[amount] == 0 ? -1 : dp[amount];
    }
}