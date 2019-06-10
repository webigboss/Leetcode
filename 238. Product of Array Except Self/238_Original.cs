public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        //left and right product lists
        var result = new int[nums.Length];
        var leftProducts = new int[nums.Length];
        var rightProducts = new int[nums.Length];
        
        var leftProductTemp = 1;
        var rightProductTemp = 1;
        for(var i = 0; i <= nums.Length - 1; i++){
            leftProductTemp *= nums[i];
            leftProducts[i] = leftProductTemp;
            rightProductTemp *= nums[nums.Length - 1 - i];
            rightProducts[nums.Length - 1 - i] = rightProductTemp;
        }
        
        for(var i = 0; i < nums.Length; i++){
            result[i] = (i - 1 >= 0 ? leftProducts[i - 1] : 1) * (i <= nums.Length - 2 ? rightProducts[i + 1] : 1);
        }
        
        return result;
    }
}