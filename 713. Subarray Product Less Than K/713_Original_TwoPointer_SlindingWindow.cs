public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
        //two pointers slinding window
        int n = nums.Length, l = 0, r = 0, p = nums[0];
        int ans = nums[0] < k ? 1 : 0;
        while(l < n && r < n){
            if(r < n - 1 && p * nums[r + 1] < k){
                r++;
                ans++;
                p *= nums[r];
            }
            else{
                p /= nums[l];
                l++;
                if(r < l && l < n){
                    p = nums[l];
                    r = l;
                }
                if(p < k)
                    ans+= r-l+1;
            }
        }
        return ans;
    }
}