public class Solution {
    public int MaximumProduct(int[] nums) {
        //sort by absolute value
        Array.Sort(nums, (a, b) => Math.Abs(b) - Math.Abs(a));
        var ans = 1;
        for(var i = 0; i < nums.Length - 2; ++i){
            for(var j = i + 1; j < nums.Length - 1; ++j){
                for(var k = j + 1; k < nums.Length; ++k){
                    ans = nums[i]*nums[j]*nums[k]; 
                    if(ans > 0) return ans;
                }
            }
        }
        return ans;
    }
}