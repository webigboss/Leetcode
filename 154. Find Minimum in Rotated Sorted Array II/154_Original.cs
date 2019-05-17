public class Solution {
    public int FindMin(int[] nums) {
        
        int start = 0;
        int end = nums.Length - 1;
        int mid;
        int result = Math.Min(nums[start], nums[end]);
        
        while(true){               
            if(start + 1 == end || start == end){
                result = Math.Min(result, Math.Min(nums[start], nums[end]));
                break;
            }
            
            mid = (start + end) / 2;
            if(nums[mid] > nums[start]){
                start = mid;
                result = Math.Min(result, nums[mid]);
            }
            else if(nums[mid] < nums[start]){
                end = mid;
                result = Math.Min(result, nums[mid]);
            }
            else{ // nums[mid] == nums[start]
                if(nums[mid] == nums[end]){
                    start++;
                    end--;
                    result = Math.Min(result, Math.Min(nums[start], nums[end]));
                }
                else if(nums[mid] > nums[end]){
                    start = mid;
                    result = Math.Min(result, nums[mid]);
                }
                else{ // nums[mid] < nums[end]
                    end = mid;
                    result = Math.Min(result, nums[mid]);
                }
                
            }
        }
        return result;
    }
}