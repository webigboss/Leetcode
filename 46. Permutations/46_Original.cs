public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        var result = new List<IList<int>>();
        Backtracking(nums, new List<int>(), result);
        return result;
    }
    
    
    private void Backtracking(int[] nums, IList<int> list, IList<IList<int>> result){
        if(list.Count == nums.Length){
            result.Add(new List<int>(list));
        }
        for(var i = 0; i < nums.Length; i++){
            if(list.Contains(nums[i]))
                continue;
            list.Add(nums[i]);
            Backtracking(nums, list, result);
            list.RemoveAt(list.Count - 1);
        }
    }
}