public class Solution {
    public int MissingNumber(int[] nums) {
        var sum1 = 0;
        var sum2 = 0;
        for(var i = 0; i < nums.Length; i++){
            sum1 += nums[i];
            sum2 += i + 1; 
        }
        return sum2 - sum1;
    }
}