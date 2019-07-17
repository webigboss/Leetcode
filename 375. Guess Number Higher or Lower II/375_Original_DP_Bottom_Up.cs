public class Solution {
    public int GetMoneyAmount(int n) {
        //DP solution bottom up
        var dp = new int[n + 1,n + 1];
        
        for(var j = 2; j <= n; j++){
            for(var i = j - 1; i >= 1; i--){
                var min = int.MaxValue;
                for(var k = i; k < j; k++){
                    min = Math.Min(min, Math.Max(dp[i, k - 1], dp[k + 1, j]) + k);
                }
                dp[i, j] = min;
            }
        }
        return dp[1, n];
    }
}