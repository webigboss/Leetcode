public class Solution {
    public int MinSteps(int n) {
        //dp bottom up
        var dp = new int[n + 1];
        //initial value set to a number that big enough
        Array.Fill(dp, n + 1);
        //base case
        dp[1] = 0;
        
        for(var i = 2; i <= n; ++i){
            for(var j = 1; j < i; ++j){
                if(i % j != 0) continue;
                dp[i] = Math.Min(dp[i], dp[j] + i/j);
            }
        }
        return dp[n];
    }
}