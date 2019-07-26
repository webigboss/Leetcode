public class Solution {
    public int Jump(int[] nums) {
        var k = nums.Length - 1;
        var jumpsCount = 0;
        while(k > 0){
            var minI = int.MaxValue;
            for(var i = k - 1; i >= 0; i--){
                if(nums[i] + i >= k)
                    minI = Math.Min(minI, i);
            }
            k = minI;
            jumpsCount++;
        }
        return jumpsCount;
    }
}