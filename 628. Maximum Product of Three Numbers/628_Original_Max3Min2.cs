public class Solution {
    public int MaximumProduct(int[] nums) {
        //find the max 3 and min 2
        //answer could only be the product of max1*max2*max3 (if they are all positive) or max1*min1*min2 or max1
        int max1, max2, max3, min1, min2, temp;
        max1 = max2 = max3 = temp = int.MinValue;
        min1 = min2 = int.MaxValue;
        
        for(var i = 0; i < nums.Length; ++i){
            if(nums[i] > max3)
                max3 = nums[i];
            if(max3 > max2){
                temp = max2;
                max2 = max3;
                max3 = temp;
            }
            if(max2 > max1){
                temp = max1;
                max1 = max2;
                max2 = temp;
            }
            
            if(nums[i] < min2){
                min2 = nums[i];
            }
            if(min2 < min1){
                temp = min1;
                min1 = min2;
                min2 = temp;
            }
        }
        return Math.Max(max1*max2*max3, max1*min1*min2);
    }
}