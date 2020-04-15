public class Solution {
    public int SubarraySum(int[] nums, int k) {
        //similar to 523, 525
        var dict = new Dictionary<int, int>();
        var sum = 0;
        var result = 0;
        dict[0] = 1;
        for(var i = 0; i < nums.Length; ++i){
            sum += nums[i];
            if(dict.ContainsKey(sum - k)){
                result += dict[sum - k];
            }
            if(!dict.ContainsKey(sum))
                dict[sum] = 1;
            else
                dict[sum]++;
        }
        return result;
    }
}