public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        var dp = new int[cost.Length+1];

        for(var i = 2; i < dp.Length; ++i){
            dp[i] = Math.Min(dp[i-2]+cost[i-2], dp[i-1]+cost[i-1]);
        }
        return dp[cost.Length];
    }
}