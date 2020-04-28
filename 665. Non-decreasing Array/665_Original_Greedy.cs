public class Solution {
    public bool CheckPossibility(int[] nums) {
        //This problem is like a greedy problem. When you find nums[i-1] > nums[i] for some i, you will prefer to change nums[i-1]'s value, since a larger nums[i] will give you more risks that you get inversion errors after position i. But, if you also find nums[i-2] > nums[i], then you have to change nums[i]'s value instead, or else you need to change both of nums[i-2]'s and nums[i-1]'s values.
        var cnt = 0;
        for(var i = 1; i < nums.Length; ++i){
            if(cnt > 1) return false;
            if(nums[i-1] > nums[i]){
                if(i>=2 && nums[i-2] > nums[i])
                    nums[i] = Math.Max(nums[i-1], nums[i-2]);
                else
                    nums[i-1] = nums[i];
                cnt++;
            }
        }
        return cnt <= 1;
    }
}