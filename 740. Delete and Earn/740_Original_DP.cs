public class Solution {
    public int DeleteAndEarn(int[] nums) {
        //Dp with reduced dementionality
        var dp = new int[2];
        Array.Sort(nums);
        
        for(var i=0; i<nums.Length; ++i){
            if(i == 0){
                dp[1] = nums[i];
                continue;
            }
            
            if(nums[i] != nums[i-1]){
                var temp = new int[2];
                temp[0] = Math.Max(dp[0], dp[1]);
                if(nums[i] - nums[i-1] == 1)
                    temp[1] = dp[0] + nums[i];
                else
                    temp[1] = Math.Max(dp[0], dp[1]) + nums[i];
                dp = temp;
            }
            else
                dp[1] += nums[i];
            
        }
        return Math.Max(dp[0], dp[1]);
    }
}