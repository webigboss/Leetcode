public class Solution {
    public int FindMaximumXOR(int[] nums) {
        //brute force solution (ime limite exceeded)
        var max = 0;
        for(var i = 0; i < nums.Length; i++){
            for(var j = 0; j < i; j++){
                max = Math.Max(max, nums[i] ^ nums[j]);
            }
        }
        return max;
    }
}