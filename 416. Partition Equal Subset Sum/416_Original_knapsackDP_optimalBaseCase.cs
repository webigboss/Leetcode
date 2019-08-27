public class Solution {
    public bool CanPartition(int[] nums) {
        //0/1 knapsack problem with optimized base case (by adding a fake base case at index 0, real DP starts at index 1)
        var sum = 0;
        foreach(var num in nums)
            sum += num; 
        if(sum % 2 == 1) return false;
        var halfSum = sum / 2;
        //transition function dp[i, j] = dp[i - 1, j] || dp[i - 1, j - nums[i]]
        var dp = new bool[nums.Length + 1, halfSum + 1]; //!!!optmized by setting the 1st dimension's length from nums.Length to nums.Length + 1, so as to avoid setting base cases for the 1st real case. instead just setting the fake case at index 0;
        //base case
        dp[0, 0] = true; 
        //dp iteration
        for(var i = 1; i <= nums.Length; i++){
            for(var j = 0; j <= halfSum; j++){
                dp[i, j] = dp[i - 1, j] || (j - nums[i - 1] < 0 ? false : dp[i - 1, j - nums[i - 1]]);
            }
        }
        
        return dp[nums.Length - 1, halfSum];
    }
}