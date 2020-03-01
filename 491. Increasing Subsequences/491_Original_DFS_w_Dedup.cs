public class Solution {
    public IList<IList<int>> FindSubsequences(int[] nums) {
        //same solution as  https://leetcode.com/problems/increasing-subsequences/discuss/97147/Java-solution-beats-100
        var result = new List<IList<int>>();
        DfsHelper(nums, 0, new List<int>(), result);
        return result;
    }
    
    private void DfsHelper(int[] nums, int index, List<int> list, IList<IList<int>> result){
        if(list.Count > 1){
            result.Add(new List<int>(list));
        }
        //use this to record numbers used in current recursion's interation, aviod to use same number twice,
        //in this tricky way it make sure the uniqueness, thus avoid to use the memo set of mine for uniqueness check
        var hsDedup = new HashSet<int>();
        for(var i = index; i < nums.Length; i++){
            if(hsDedup.Contains(nums[i])) continue;
            if(list.Count > 0 && nums[i] < list[list.Count - 1]) continue;
            list.Add(nums[i]);
            hsDedup.Add(nums[i]);
            DfsHelper(nums, i + 1, list, result);
            list.RemoveAt(list.Count - 1);
        }
    }
}