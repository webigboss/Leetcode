public class Solution {
    public bool CanPartition(int[] nums) {
        //0/1 knapsack problem
        var sum = 0;
        foreach(var num in nums)
            sum += num; 
        if(sum % 2 == 1) return false;
        var halfSum = sum / 2;
        //transition function dp[i, j] = dp[i - 1, j] || dp[i - 1, j - nums[i]]
        var dp = new bool[nums.Length, halfSum + 1];
        //base case
        dp[0, 0] = true; 
        if(nums[0] <= halfSum)
            dp[0, nums[0]] = true;
        //dp iteration
        for(var i = 1; i < nums.Length; i++){
            for(var j = 0; j <= halfSum; j++){
                dp[i, j] = dp[i - 1, j] || (j - nums[i] < 0 ? false : dp[i - 1, j - nums[i]]);
            }
        }
        
        return dp[nums.Length - 1, halfSum];
    }
}