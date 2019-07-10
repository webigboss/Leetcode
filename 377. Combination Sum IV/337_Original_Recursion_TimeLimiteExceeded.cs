public class Solution {
    public int CombinationSum4(int[] nums, int target) {
        //recursion solution
        
        //base case
        if(target == 0)
            return 1;
        
        var result = 0;
        for(var i = 0; i < nums.Length; i++){
            if(target >= nums[i])
                result += CombinationSum4(nums, target - nums[i]);
        }
        return result; 
    }
}