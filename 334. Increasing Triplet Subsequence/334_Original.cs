public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        // check if the max so far increased 3 times
        int max = int.MinValue;
        int min = int.MaxValue;
        int imax = 0;
        int imin = 0;
        
        for(var i = 0; i < nums.Length; i++){
            if(nums[i] < min){
                min = nums[i];
                imin = i;
            }
            if(nums[i] >= max){
                max = nums[i];
                imax = i;
            }
        }
        int lessThanMaxCount = 0;
        int lastLessThanMaxValue = 0;
        int greaterThanMinCount = 0;
        int lastGreaterThanMinValue = 0;
        for(var i = 0; i < nums.Length; i++){
            if(i < imax && nums[i] < max){
                if(lessThanMaxCount == 0){
                    lessThanMaxCount++;
                    lastLessThanMaxValue = nums[i];
                }
                else{
                    if(nums[i] > lastLessThanMaxValue)
                        lessThanMaxCount++;    
                }
            }
            if(i > imin && nums[i] > min){
                if(greaterThanMinCount == 0){
                    greaterThanMinCount++;
                    lastGreaterThanMinValue = nums[i];
                }
                else{
                    if(nums[i] > lastGreaterThanMinValue)
                        greaterThanMinCount++;
                }
            }
                
        }
        if(lessThanMaxCount >= 2 || greaterThanMinCount >=2)
            return true;
        return false;
    }
}