public class Solution {
    public int FindMaxLength(int[] nums) {
        //similar to 523, one pass with hashtable record sum
        var dict = new Dictionary<int, int>();
        dict[0] = -1;
        var sumAt = 0;
        var maxLength = 0;
        for(var i = 0; i < nums.Length; ++i){
            sumAt += nums[i] == 0 ? -1 : nums[i];
            if(dict.ContainsKey(sumAt))
                maxLength = Math.Max(maxLength, i - dict[sumAt]);
            else
                dict[sumAt] = i;
        }
        return maxLength;
    }
}