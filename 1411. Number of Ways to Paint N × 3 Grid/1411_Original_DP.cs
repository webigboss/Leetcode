public class Solution {
    public int NumOfWays(int n) {
        //inspired by https://leetcode.com/problems/number-of-ways-to-paint-n-3-grid/discuss/574923/JavaC%2B%2BPython-DP-O(1)-Space
        //dp[i, j]: i: the ist row to paint, j=0 case '121', j=1: case '123'
        var dp = new long[n + 1, 2];
        //base case
        dp[1, 0] = 6;
        dp[1, 1] = 6;
        int mod = (int)(Math.Pow(10, 9) + 7);
        for(var i = 2; i <= n; ++i){
            dp[i, 0] = dp[i - 1, 0] * 3 + dp[i - 1, 1] * 2;
            dp[i, 0] %= mod;
            dp[i, 1] = dp[i - 1, 0] * 2 + dp[i - 1, 1] * 2;
            dp[i, 1] %= mod;
        }
        
        var result = (dp[n, 0] + dp[n, 1]) % mod;
        return (int)result;
    }
}