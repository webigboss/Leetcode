public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var ht = new Hashtable();
        
        for(var i = 0; i < nums.Length; i++){
            if(ht.Contains(nums[i]))
                return true;
            else
                ht.Add(nums[i], null);
        }
        return false;
    }
}