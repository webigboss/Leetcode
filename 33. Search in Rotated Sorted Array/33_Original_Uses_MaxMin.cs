public class Solution {
    public int Search(int[] nums, int target) {
        int start = 0;
        int end = nums.Length - 1;
        int mid = 0;
        
        while(start <= end){
            mid = (start + end) / 2;
            int val = 0; 
            if(nums[mid] < nums[start] == target < nums[start]) // nums[mid] and target on the same side
                val = nums[mid];
            else{ // nums[mid] and target of different side
                if(nums[mid] < nums[start]) //nums[mid] on the lower part on the tail, target on the higher part on the head
                    val = int.MaxValue;
                else
                    val = int.MinValue;
            }
                
            if(val == target)
                return mid;
            else if(val > target){
                end = mid - 1;
            }
            else
                start = mid + 1;
        }
        return -1;
    }
}