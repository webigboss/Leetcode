public class Solution {
    public int ConstrainedSubsetSum(int[] nums, int k) {
        //DP (brute force without optimization)
        //dp[i]: the max subset sum with last element ends at i;
        var dp = new int[nums.Length];
        
        //base case
        dp[0] = nums[0];
        var ans = dp[0];
        for(var i = 1; i < nums.Length; ++i){
            dp[i] = nums[i];
            
            for(var j = Math.Max(i-k,0); j < i; ++j){
                dp[i] = Math.Max(dp[i], dp[j] + nums[i]);
            }
            ans = Math.Max(ans, dp[i]);
        }        
        return ans;
    }
}