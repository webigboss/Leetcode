public class Solution {
    public int NumTrees(int n) {
        var dp = new int[n + 1];
        dp[0] = 1;
        dp[1] = 1;
        
        for(var i = 2; i <= n; i++){
            for(var j = 0; j <= i - 1; j++){
                dp[i] += dp[j] * dp[i - 1 - j];
            }
        }
        
        return dp[n];
    }
}