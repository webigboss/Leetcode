public class Solution {
    public int LongestSubarray(int[] nums, int limit) {
        //two pointers slidling window
        int l = 0, r = 0, max = -1, min = nums[0], ans = 0;
        while(r < nums.Length){
            min = Math.Min(min, nums[r]);
            max = Math.Max(max, nums[r]);
            if(max - min <= limit){
                ans = Math.Max(ans, r-l+1);
                r++;
            }
            else{
                l++;
                if(min == nums[l-1] || max == nums[l-1]){
                    r = l;
                    max = min = nums[l];
                }
                if(r < l) r = l;
            }
        }
        return ans;
    }
}