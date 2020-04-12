public class Solution {
    public int SingleNonDuplicate(int[] nums) {
        //binary search, check if the first number of the pair start with even or odd index
        //before the single number, first number is with even index, after will be odd
        var lo = 0;
        var hi = nums.Length - 1;
        var mid = 0;
        var startWithEven = true;
        while(lo < hi){
            mid = (lo + hi) / 2;
            if(mid == 0){
                if(nums[0] != nums[1]) return nums[0];
                startWithEven = true;
            }   
            else if(mid == nums.Length - 1){
                if(nums[nums.Length - 1] != nums[nums.Length - 2]) 
                    return nums[nums.Length - 1];
                startWithEven = false;
            }
            else{ // 0 < mid < nums.Length
                if(nums[mid] < nums[mid + 1] && nums[mid] > nums[mid - 1]) return nums[mid];
                if(nums[mid] == nums[mid - 1]){
                    startWithEven = (mid - 1) % 2 == 0;
                }
                else
                    startWithEven = mid % 2 == 0;
            }
            if(startWithEven){
                //single element is after mid
                lo = mid + 1;
            }
            else{
                //single element is before mid
                hi = mid - 1;
            }
        }
        return nums[lo];
    }
}