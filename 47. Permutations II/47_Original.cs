public class Solution {
    public IList<IList<int>> PermuteUnique(int[] nums) {
        var result = new List<IList<int>>();
        var ht = new Hashtable();
        Backtracking(nums, 0, new List<int>(), new List<int>(), result, ht);
        return result;
    }
    
    private void Backtracking(int[] nums, int sum, IList<int> list, IList<int> usedIndexes, IList<IList<int>> result, Hashtable ht){
        if(list.Count == nums.Length){
            if(!ht.ContainsKey(sum)){
                result.Add(new List<int>(list));
                ht.Add(sum, null);
            }
            return;
        }
        for(var i = 0; i < nums.Length; i++){
            if(usedIndexes.Contains(i))
                continue;
            list.Add(nums[i]);
            usedIndexes.Add(i);
            Backtracking(nums, sum * 10 + nums[i], list, usedIndexes, result, ht);
            list.RemoveAt(list.Count - 1);
            usedIndexes.RemoveAt(usedIndexes.Count - 1);
        }
    }
}