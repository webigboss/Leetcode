public class Solution {
    public int MinSubArrayLen(int s, int[] nums) {
        var minLen = int.MaxValue;
        var sum = 0;
        var left = 0;
        for(var i = 0; i <= nums.Length - 1; i++){
            sum += nums[i];
            while(sum >= s){
                minLen = Math.Min(minLen, i - left + 1);
                sum -= nums[left];
                left++;
            }
        }
        return minLen == int.MaxValue ? 0 : minLen;
    }
}