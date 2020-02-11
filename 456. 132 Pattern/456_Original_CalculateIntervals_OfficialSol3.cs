public class Solution {
    public bool Find132pattern(int[] nums) {
        //offcial 3rd solution: calculate intervals
        if(nums == null || nums.Length == 0)
            return false;
        var minArray = new int[nums.Length];
        minArray[0] = nums[0];
        var j = 0;
        for(var i = 1; i < nums.Length; i++) {
            minArray[i] = Math.Min(minArray[i - 1], nums[i]);
            //trace back intervals for finding a index j (j < i) that nums[j] > nums[i] && nums[i] > minArray[i]
            j = i - 1;
            while(j >= 0){
                if(nums[j] > nums[i] && nums[i] > minArray[j])
                    return true;
                j--;
            }
        }
        return false;
    }
}