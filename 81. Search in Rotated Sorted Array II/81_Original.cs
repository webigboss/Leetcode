public class Solution {
    public bool Search(int[] nums, int target) {
        int start = 0;
        int end = nums.Length - 1;
        int mid = 0;
        
        while(start <= end){
            mid = (start + end) / 2;
            #region the only different part vs 33. Search in Rotated Sorted Array, to solve tail with repeating numbers as the nums[0], if the array all have same element and target is different value, will get the worst case time complexity O(n) because this piece of code will be run for every element
            if(start < end && nums[start] == nums[end]){
                end--;
                continue;
            }
            #endregion
            if(nums[mid] == target)
                return true;
            if(nums[start] == target)
                return true;
            if(nums[mid] >= nums[start]){
                //!!!below conditional cases can be simplified
                //nums[mid] in head
                if(target > nums[start]) {
                    // target in head too
                    if(target < nums[mid])
                        end = mid - 1;
                    else // target > nums[mid] no equal
                        start = mid + 1;
                }
                else{ // target < nums[start] no equal
                    //target is tail
                    start = mid + 1;
                }
            }
            else{
                //!!!below conditional cases can be simplified
                //nums[mid] in tail
                if(target < nums[start]){
                    // target in tail 
                    if(target < nums[mid]){
                        end = mid - 1;
                    }
                    else{
                        start = mid + 1;
                    }
                }
                else{
                    //target in head
                    end = mid - 1;
                }
            }
                
        }
        return false;
    }
}