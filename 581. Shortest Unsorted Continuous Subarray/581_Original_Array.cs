public class Solution {
    public int FindUnsortedSubarray(int[] nums) {
        var min = int.MaxValue;
        var max = int.MinValue;
        
        //find the miminum after find the first occurance that breaks the ascending order
        var found = false;
        for(var i = 1; i < nums.Length; ++i){
            if(nums[i] < nums[i - 1])
                found = true;
            if(found)
                min = Math.Min(min, nums[i]);
        }
        if(!found) return 0;
        var lo = 0;
        for(var i = 0; i < nums.Length; ++i){
            if(nums[i] > min){
                lo = i;
                break;
            }
        }
        
        found = false;
        for(var i = nums.Length - 2; i >= 0; --i){
            if(nums[i] > nums[i + 1])
                found = true;
            if(found)
                max = Math.Max(max, nums[i]);
        }
        var hi = 0;
        for(var i = nums.Length - 1; i >=0 ; --i){
            if(nums[i] < max){
                hi = i;
                break;
            }
        }
        return hi - lo + 1;
        
    }
}