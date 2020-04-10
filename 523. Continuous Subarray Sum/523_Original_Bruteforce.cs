public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {
        for(var i = 0; i < nums.Length - 1; ++i){
            var sum = nums[i];
            for(var j = i + 1; j < nums.Length; ++j){
                sum += nums[j];
                if(k == 0 && sum == 0) return true; 
                if(k != 0 && sum % k == 0) return true;
            }
        }
        return false;
    }
}