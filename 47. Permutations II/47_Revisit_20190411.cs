public class Solution {
    public IList<IList<int>> PermuteUnique(int[] nums) {
        var result = new List<IList<int>>();
        Array.Sort(nums);
        var used = new bool[nums.Length];
        BacktrackingHelper(nums, new List<int>(), used, result);
        return result;
    }
    
    private void BacktrackingHelper(int[] nums, IList<int> list, bool[] used, IList<IList<int>> result){
        if(list.Count == nums.Length)
            result.Add(new List<int>(list));
        
        for(var i = 0; i <= nums.Length - 1; i++){
            if(used[i] || i > 0 && nums[i - 1] == nums[i] && used[i - 1]) continue;
            used[i] = true;
            list.Add(nums[i]);
            BacktrackingHelper(nums, list, used, result);
            list.RemoveAt(list.Count - 1);
            used[i] = false;
        }
    }
}