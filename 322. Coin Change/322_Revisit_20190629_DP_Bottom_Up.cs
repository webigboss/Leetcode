//6/29/2019: improved the code by removed some unneccessary logic
public class Solution {
    public int CoinChange(int[] coins, int amount) {
        if(amount == 0)
            return 0;
        var dp = new int[amount + 1];
        Array.Fill(dp, amount + 1);
        //base case
        dp[0] = 0;
        for(var i = 1; i <= amount; i++){
            for(var j = 0; j < coins.Length; j++){
                if(i - coins[j] >= 0){
                    dp[i] = Math.Min(dp[i], dp[i - coins[j]] + 1);
                }
            }   
        }
        //return dp[1];
        return dp[amount] == amount + 1 ? -1 : dp[amount];
    }
}