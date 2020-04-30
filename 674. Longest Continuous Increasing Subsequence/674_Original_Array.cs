public class Solution {
    public int FindLengthOfLCIS(int[] nums) {
        if(nums.Length == 0)
        var cnt = 1;
        var ans = 1;
        for(var i = 1; i < nums.Length; ++i){
            if(nums[i] > nums[i-1]){
                cnt++;
                ans = Math.Max(ans, cnt);   
            }
            else
                cnt=1;
                     
        }
        return ans;
    }
}