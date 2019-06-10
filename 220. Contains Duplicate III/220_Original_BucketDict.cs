public class Solution {
    public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t) {
        // bucket solution, leveraging the fact that all the nums with the same remainder will be within the range of a divider
        if(nums.Length == 0 || k == 0 || t < 0)
            return false;
        var dict = new Dictionary<long, long>();
        
        for(var i = 0; i < nums.Length; i++){
            // why t+1 ? because, if t not plus 1, when t == 0, num divide by 0 will cause crash.
            long adjustedNum = (long)nums[i] - int.MinValue;
            long bucket = adjustedNum / ((long)t + 1);
            
            if(dict.ContainsKey(bucket) // means the key in the map duplicated, it means the must be exist two numbers that the different value between them are less than t
              || dict.ContainsKey(bucket + 1) && dict[bucket + 1] - adjustedNum <= t // if the two different numbers are located in two adjacent bucket, the value still might be less than t
              || dict.ContainsKey(bucket - 1) && adjustedNum - dict[bucket - 1] <= t) // the same reason for -1
                return true;
            
            if(dict.Count >= k){// there won't be key duplication at this point (will return true in above if statement), we can just remove the dictionay item at i - k
                dict.Remove(((long)nums[i - k] - int.MinValue) / ((long)t + 1));
            }
            dict[bucket] = adjustedNum;
        }
        return false;
    }
}