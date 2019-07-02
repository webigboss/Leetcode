public class Solution {
    public int IntegerBreak(int n) {
        // Math solution
        // If an optimal product contains a factor f >= 4, then you can replace it with factors 2 and f-2 without losing optimality, as 2*(f-2) = 2f-4 >= f. So you never need a factor greater than or equal to 4, meaning you only need factors 1, 2 and 3 (and 1 is of course wasteful and you'd only use it for n=2 and n=3, where it's needed).
        // For the rest I agree, 3*3 is simply better than 2*2*2, so you'd never use 2 more than twice.
        
        if(n == 2)
            return 1;
        if(n == 3)
            return 2;
        if(n == 4)
            return 4;
        var dp = new int[n + 1];
        //base case:
        dp[2] = 1;
        dp[3] = 2;
        dp[4] = 4;
        for(var i = 5; i <= n; i++){
            dp[i] = Math.Max(dp[i - 1], 
                             Math.Max(Math.Max(dp[i - 2] * 2, (i - 2) * 2), Math.Max(dp[i - 3] * 3, (i - 3) * 3)));
        }
        return dp[n];
    }
}