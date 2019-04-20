public class Solution {
    public int FindMin(int[] nums) {
        int start = 0;
        int end = nums.Length - 1;
        int mid = 0;
        int min = Math.Min(nums[start], nums[end]);
        while(start <= end){
            mid = (start + end) / 2;
            if(nums[mid] < nums[start]){
                //nums[mid] is in the tail
                end = mid;
                min = Math.Min(min, nums[mid]);
            }
            else if (nums[mid] > nums[start]){
                //nums[mid] > nums[start], nums[mid] is in the head
                start = mid;
                min = Math.Min(min, nums[start]);
            }
            else{ 
                //nums[mid] == nums[start], end == mid + 1
                mid = nums[start] < nums[end] ? start : end;
                min = Math.Min(min, nums[mid]);
               break;
            } 
        }
        return min;
    }
}