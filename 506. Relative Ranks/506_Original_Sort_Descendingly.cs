public class Solution {
    public string[] FindRelativeRanks(int[] nums) {
        var result = new string[nums.Length];
        var dict = new Dictionary<int, int>();
        for(var i = 0; i < nums.Length; ++i)
            dict[nums[i]] = i;
        //sort descendingly
        Array.Sort(nums, (a, b) => b - a);
        
        for(var i = 0; i < nums.Length; ++i){
            var index = dict[nums[i]];
            if(i == 0)
                result[index] = "Gold Medal";
            else if(i == 1)
                result[index] = "Silver Medal";
            else if(i == 2)
                result[index] = "Bronze Medal";
            else
                result[index] = (i + 1).ToString();
        }
        return result;
    }
}