public class Solution {
    public string[] FindRelativeRanks(int[] nums) {
        var result = new string[nums.Length];
        var dict = new Dictionary<int, int>();
        for(var i = 0; i < nums.Length; ++i)
            dict[nums[i]] = i;
        Array.Sort(nums);
        
        for(var i = nums.Length - 1; i >= 0; --i){
            var index = dict[nums[i]];
            if(i == nums.Length - 1)
                result[index] = "Gold Medal";
            else if(i == nums.Length - 2)
                result[index] = "Silver Medal";
            else if(i == nums.Length - 3)
                result[index] = "Bronze Medal";
            else
                result[index] = (nums.Length - i).ToString();
        }
        return result;
    }
}