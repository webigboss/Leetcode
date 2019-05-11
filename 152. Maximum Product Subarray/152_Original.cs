public class Solution {
    public int MaxProduct(int[] nums) {
        //dp solution, inspried and optimized from the dp prototype solution here:
        //https://leetcode.com/problems/maximum-product-subarray/discuss/48230/Possibly-simplest-solution-with-O(n)-time-complexity/181239
        // maintain the max and min Product while doing a one pass algorithm, and during each iteration, get the min max from the
        // three candidates: nums[i], min=min(prevmin*nums[i], prevmax*nums[i]), max=max(prevmin*nums[i], prevmax*nums[i]);
        if(nums.Length == 0)
            return 0;
        var globalMax = nums[0];
        var max = int.MinValue;
        var min = int.MaxValue;
        var prevMax = nums[0];
        var prevMin = nums[0];
        
        for(var i = 1; i < nums.Length; i++){
            max = Math.Max(nums[i], Math.Max(prevMin * nums[i], prevMax * nums[i]));
            min = Math.Min(nums[i], Math.Min(prevMin * nums[i], prevMax * nums[i]));
            globalMax = Math.Max(max, globalMax);
            prevMax = max;
            prevMin = min;
        }
        
        return globalMax;
    }
}