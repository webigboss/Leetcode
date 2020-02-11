public class Solution {
    public bool Find132pattern(int[] nums) {
        //official solution 2: better brute force
        var min = int.MaxValue;
        for(var i = 0; i < nums.Length; i++){
            //min = Math.Min(min, nums[i]); can also be put here as even if min is nums[j], they won't pass the if statement down below 
            for(var j = i + 1; j < nums.Length; j++){
                if(nums[i] > nums[j] && nums[j] > min)
                    return true;
            }
            min = Math.Min(min, nums[i]);
        }
        return false;
    }
}