public class Solution {
    public bool KLengthApart(int[] nums, int k) {
        if(k == 0) return true;
        var cnt = 0;
        for(var i = 0; i < nums.Length; ++i){
            if(i != 0 && nums[i] == 1){
                if(cnt < k)
                    return false;
                cnt = 0;
            }
            if(nums[i] == 0)
                cnt++;
        }
        return true;
    }
}