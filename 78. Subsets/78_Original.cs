public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        Array.Sort(nums);
        var result = new List<IList<int>>();
        
        for(var i = 0; i <= nums.Length; i++){
            SubsetsBacktracking(nums, i, 0, new List<int>(), result);
        }
        return result;
    }
    
    public void SubsetsBacktracking(int[] nums, int count, int start, IList<int> list, IList<IList<int>> result){
        if(list.Count == count)
            result.Add(new List<int>(list));
        for(var i = start; i < nums.Length; i++){
            list.Add(nums[i]);
            SubsetsBacktracking(nums, count, i + 1, list, result);
            list.RemoveAt(list.Count - 1);
        }
    }
}