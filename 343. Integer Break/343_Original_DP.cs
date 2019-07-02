public class Solution {
    public int IntegerBreak(int n) {
        // DP solution
        var dp = new int[n + 1];
        //base case
        dp[2] = 1;
        
        for(var i = 3; i <= n; i++){
            for(var j = 1; j < i; j++){
                dp[i] = Math.Max(dp[i], Math.Max(j * (i - j), j * dp[i - j]));
            }
        }
        return dp[n];
    }
}