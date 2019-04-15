public class Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);
        var result = new List<IList<int>>();
        for(var i = 0; i <= nums.Length; i++){
            SubsetsWithDupBacktracking(nums, 0, i, new List<int>(), result);
        }
        return result;
    }
    
    private void SubsetsWithDupBacktracking(int[] nums, int start, int count, IList<int> list, IList<IList<int>> result){
        if(list.Count == count)
            result.Add(new List<int>(list));
        
        for(var i = start; i < nums.Length; i++){
            if(i > start && nums[i - 1] == nums[i])
                continue;
            list.Add(nums[i]);
            SubsetsWithDupBacktracking(nums, i + 1, count, list, result);
            list.RemoveAt(list.Count - 1);
        }
    }
}