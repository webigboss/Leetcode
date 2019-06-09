public class Solution {
    public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t) {
        if(nums.Length == 0 || t < 0 || k == 0)
            return false;
        var ss = new SortedSet<long>();
        
        for(var i = 0; i < nums.Length; i++){
            if(i == 0){
                ss.Add(nums[i]);
                continue;
            }
            
            var max = ss.Max;
            var min = ss.Min;
            
            if(nums[i] > max && nums[i] <= max + t || nums[i] < min && nums[i] >= min - t
               || ss.GetViewBetween((long)nums[i] - t, (long)nums[i] + t).Count > 0)
                return true;
            ss.Add(nums[i]);
            
            if(i >= k)
                ss.Remove(nums[i - k]);
        }
        
        return false;
    }
}