public class Solution {
    public int PivotIndex(int[] nums) {
        var sum = 0;
        foreach(var n in nums)
            sum+=n;
        var cur = 0;
        for(var i = 0; i < nums.Length; ++i){
            if(sum - nums[i] - cur == cur)
                return i;
            cur += nums[i];
        }
        return -1;
    }
}