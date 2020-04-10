public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {
        var sumAt = 0;
        var dict = new Dictionary<int, int>(); //mod -> index
        dict[0] = -1; 
        for(var i = 0; i < nums.Length; ++i){
            sumAt += nums[i];
            if(k != 0) sumAt %= k;
            if(dict.ContainsKey(sumAt)){
                if(i - dict[sumAt] > 1) return true;
            }
            else
                dict[sumAt] = i;
        }
        return false;
    }
}