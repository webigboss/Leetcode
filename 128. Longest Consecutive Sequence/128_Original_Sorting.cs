public class Solution {
    public int LongestConsecutive(int[] nums) {
        //sorting solution
        if(nums.Length == 0)
            return 0;
        Array.Sort(nums);
        var result = 1;
        var counter = 1;
        for(var i = 1; i < nums.Length; i++){
            if(nums[i] - nums[i - 1] == 1) {
                counter++;
            }
            else if(nums[i] - nums[i - 1] == 0)
                continue;
            else{
                result = Math.Max(result, counter);
                counter = 1;
            }
        }
        return Math.Max(result, counter);
    }
}