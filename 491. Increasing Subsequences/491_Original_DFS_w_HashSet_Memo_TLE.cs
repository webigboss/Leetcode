public class Solution {
    public IList<IList<int>> FindSubsequences(int[] nums) {
        var memo = new HashSet<long>();
        var result = new List<IList<int>>();
        if(nums.Length == 0) return result;
        DfsHelper(nums, 0, new List<int>{ nums[0] }, memo, result);
        return result;
    }
    
    private void DfsHelper(int[] nums, int index, IList<int> list, HashSet<long> memo, IList<IList<int>> result) {
        if(list.Count > 1){
            var l = CalculateFromList(list);
            if(!memo.Contains(l)){
                //new a list, otherwise result will be polutted succeeding operations on list;
                result.Add(new List<int>(list));
                memo.Add(l);
            }
        }
        
        if(index == nums.Length - 1) return;

        for(var i = index + 1; i < nums.Length; i++){
            //case 1. new subsequence starting from i
            DfsHelper(nums, i, new List<int>{ nums[i] }, memo, result);
            //case 2. continue appending existing subsequence if number is not decreasing
            if(nums[i] < list[list.Count - 1]) continue;
            list.Add(nums[i]);
            DfsHelper(nums, i, list, memo, result);
            list.Remove(nums[i]);
        }
    }
    
    private long CalculateFromList(IList<int> list){
        var factor = 1;
        var result = 0;
        for(var i = list.Count - 1; i >= 0; i--){
            result += list[i] * factor;
            factor *= 10;
        }
        return result;
    }
}