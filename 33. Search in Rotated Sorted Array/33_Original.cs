public class Solution {
    public int Search(int[] nums, int target) {
        int start = 0;
        int end = nums.Length - 1;
        int mid = 0;
        
        while(start <= end){
            mid = (start + end) / 2;
            
            if(nums[mid] == target)
                return mid;
            if(nums[start] == target)
                return start;
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
        return -1;
    }
}