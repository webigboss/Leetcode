public class Solution {
    public int FirstMissingPositive(int[] nums) {
        var max = int.MinValue;
        var min = int.MaxValue;
        var hs = new HashSet<int>();
        for(var i = 0; i < nums.Length; i++){
            if(nums[i] <= 0) continue;
            max = Math.Max(max, nums[i]);
            min = Math.Min(min, nums[i]);
            if(!hs.Contains(nums[i]))
                hs.Add(nums[i]);
        }
        
        if(min > 1)
            return 1;
        
        for(var i = min + 1; i <= max; i++){
            if(!hs.Contains(i))
                return i;
        }
        return max + 1;
    }
}