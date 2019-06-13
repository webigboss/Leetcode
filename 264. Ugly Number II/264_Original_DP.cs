public class Solution {
    public int NthUglyNumber(int n) {
        // DP solution
        if(n <= 0)
            return 0;
        // dp array to store the ugly numbers
        var dp = new int[n];
        //base case
        dp[0] = 1;
        int i2 = 0, i3 = 0, i5 = 0;
        for(var i = 1; i < n; i++){
            dp[i] = Math.Min(dp[i2]*2, Math.Min(dp[i3]*3, dp[i5]*5));
            if(dp[i] == dp[i2]*2) i2++;
            if(dp[i] == dp[i3]*3) i3++;
            if(dp[i] == dp[i5]*5) i5++;
        }
        return dp[n - 1];
        
    }
}