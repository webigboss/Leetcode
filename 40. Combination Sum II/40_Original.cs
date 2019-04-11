public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        var result = new List<IList<int>>();
        var ht = new Hashtable();
        Array.Sort(candidates);
        Backtracking(candidates, target, 0, new List<int>(), result, ht, 0);
        return result;
    }
    
    private void Backtracking(int[] nums, int remains, int start, IList<int> list, IList<IList<int>> result, Hashtable ht, int sum){
        if(remains == 0){
            if(ht.ContainsKey(sum))
                return;
            result.Add(new List<int>(list));
            ht.Add(sum, null);
            return;
        }
        if(remains < 0)
            return;
        for(var i = start; i <= nums.Length - 1; i++){
            list.Add(nums[i]);
            Backtracking(nums, remains - nums[i], i + 1, list, result, ht, sum * 10 + nums[i]);
            list.RemoveAt(list.Count - 1);
        }
    }
    
}