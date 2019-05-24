public class Solution {
    public int Rob(int[] nums) {
        // DP solution
        if(nums.Length == 0)
            return 0;
        
        var dp = new int[nums.Length + 1];
        
        //base case is dp[0] = 0, no need to set
        dp[1] = nums[0];
        
        for(var n = 2; n <= nums.Length; n++){
            dp[n] = Math.Max(dp[n - 1], nums[n - 1] + dp[n - 2]);
        }
        
        return dp[nums.Length];
    }
}