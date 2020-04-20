public class Solution {
    public int TriangleNumber(int[] nums) {
        //3 Sum like
        Array.Sort(nums);
        var result = 0;
        for(var i = 2; i < nums.Length; ++i){
            var left = 0; 
            var right = i - 1;
            while(left < right){
                if(nums[i] < nums[left] + nums[right]){
                    //since nums is sorted, nums[right] + nums[left + 1] > nums[right] + nums[left] > nums[i]
                    //so left can take [left, right -1] elements, which equal right - left;
                    result += right - left;
                    right--;                    
                }
                else
                    left++;
            }
        }
        return result;
    }
}