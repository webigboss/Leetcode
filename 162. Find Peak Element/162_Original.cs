public class Solution {
    public int FindPeakElement(int[] nums) {
        int start = 0;
        int end = nums.Length - 1;
        int mid = 0;
        int peak = 0;
        while(start <= end){
            mid = (start + end) / 2;
            
            if(start == end){
                peak = start;
                break;
            }
            
            if(mid == 0 && nums.Length > 1 && nums[mid] > nums[mid + 1]){
                peak = mid;
                break;
            }
            
            if(mid == nums.Length - 1 && nums.Length > 1 && nums[mid] > nums[mid - 1]){
                peak = mid;
                break;
            }
            
            if(mid > 0 && nums[mid - 1] < nums[mid] && mid < nums.Length - 1 && nums[mid + 1] < nums[mid]){
                peak = mid;
                break;
            }
            
            if(mid > 0 && nums[mid - 1] > nums[mid]){
                end = mid - 1;
                continue;
            }
            
            if(mid < nums.Length - 1 && nums[mid + 1] > nums[mid]){
                start = mid + 1;
                continue;
            }
        }
        return peak;
    }
}