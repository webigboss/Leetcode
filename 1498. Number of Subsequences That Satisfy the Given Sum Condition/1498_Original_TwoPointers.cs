public class Solution {
    int mod = (int)(1e9) + 7;
    public int NumSubseq(int[] nums, int target) {
        int ans = 0, l = 0, r = nums.Length - 1;
        var pows = new int[nums.Length];
        pows[0] = 1;
        
        for(var i = 1; i < pows.Length; ++i){
            pows[i] = pows[i-1] * 2 % mod;
        }
        
        Array.Sort(nums);
        while(l <= r){
            if(nums[l] + nums[r] > target)
                r--;
            else{
                ans += pows[r-l];
                ans %= mod;
                l++;
            }
        }
        return ans % mod;
        
    }
}