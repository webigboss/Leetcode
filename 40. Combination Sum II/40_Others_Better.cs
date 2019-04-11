public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        var result = new List<IList<int>>();
        Array.Sort(candidates);
        Backtracking(candidates, target, 0, new List<int>(), result);
        return result;
    }
    
    private void Backtracking(int[] nums, int remains, int start, IList<int> list, IList<IList<int>> result){
        if(remains == 0){
            result.Add(new List<int>(list));
            return;
        }
        if(remains < 0)
            return;
        for(var i = start; i <= nums.Length - 1; i++){
            // remove duplicates by skipping elements with same values
            // in the save level of loop. please note that this will not impact 
            // answers with duplicates elements because it will be done in next level's 
            // iteration.
            if(i > start && nums[i] == nums[i - 1]) 
                continue;
            list.Add(nums[i]);
            Backtracking(nums, remains - nums[i], i + 1, list, result);
            list.RemoveAt(list.Count - 1);
        }
    }
    
}