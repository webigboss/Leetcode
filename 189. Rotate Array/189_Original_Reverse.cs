public class Solution {
    public void Rotate(int[] nums, int k) {
        //multiple reverse solution
        k = k % nums.Length;
        Reverse(nums, 0, nums.Length - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, nums.Length - 1);
    }
    
    private void Reverse(int[] nums, int start, int end){
        int temp;
        while(start < end){
            temp = nums[start];
            nums[start++] = nums[end];
            nums[end--] = temp;
        }
    }
}