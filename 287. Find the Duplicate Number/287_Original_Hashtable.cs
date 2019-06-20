public class Solution {
    public int FindDuplicate(int[] nums) {
        //hashtable solution, T: O(n), S: O(n)
        var hs = new HashSet<int>();
        for(var i = 0; i < nums.Length; i++){
            if(!hs.Contains(nums[i]))
                hs.Add(nums[i]);
            else
                return nums[i];
        }
        return 0;
    }
}