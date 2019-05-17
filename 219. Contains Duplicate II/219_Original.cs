public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var ht = new Hashtable();
        var maxGap = int.MaxValue;
        for(var i = 0; i < nums.Length; i++){
            if(!ht.Contains(nums[i])){
                ht.Add(nums[i], i);
            }
            else {
                maxGap = Math.Min(maxGap, i - (int)ht[nums[i]]);
                if(maxGap <= k)
                    return true;
                ht[nums[i]] = i;
            }
            
        }
        return false;
    }
}