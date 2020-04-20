public class Solution {
    public int TriangleNumber(int[] nums) {
        //brute force
        Array.Sort(nums);
        var result = 0;
        for(var i = 0; i < nums.Length - 2; ++i){
            for(var j = i+1; j < nums.Length - 1; ++j){
                for(var k = j+1; k < nums.Length; ++k){
                    if(nums[k] < nums[i] + nums[j])
                        result++;
                }
            }
        }
        return result;
    }
}