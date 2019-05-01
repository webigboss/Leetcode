public class Solution {
    public int UniquePaths(int m, int n) {
        // DP solution
        // create a 2D Array dp[m + 1,n + 1] represent the count of unique paths at (m,n)
        // the pattern is dp[m, n] = dp[m - 1, n] + dp[m, n - 1]
        // base cases: dp[1,1] = 0, dp[x, 0] = 1, dp[0, y] = 1;
        
        var dp = new int[m + 1, n + 1];
        dp[1, 1] = 1;
        
        for(var i = 1; i <= m; i++){
            for(var j = 1; j <= n; j++){
                if(i == 1 && j == 1)
                    continue;
                dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
            }
        }
        return dp[m, n];
    }
}