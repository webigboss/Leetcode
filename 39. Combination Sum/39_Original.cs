public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        var result = new List<IList<int>>();
        Array.Sort(candidates);
        CombinationSumBackTracking(candidates, target, new List<int>(), result, 0);
        return result;
    }
    
    
    private void CombinationSumBackTracking(int[] nums, int remain, IList<int> list, IList<IList<int>> result, int start){
        if(remain == 0){
            result.Add(new List<int>(list));
        }
        if(remain < 0)
            return;
        for(var i = start; i < nums.Length; i++){
            list.Add(nums[i]);
            CombinationSumBackTracking(nums, remain - nums[i], list, result, i);
            list.RemoveAt(list.Count - 1);
        }
    }
}