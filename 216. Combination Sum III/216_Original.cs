public class Solution {
    public IList<IList<int>> CombinationSum3(int k, int n) {
        var result = new List<IList<int>>();
        BacktrackingHelper(n, k, 1, new List<int>(), result);
        return result;
    }
    
    private void BacktrackingHelper(int remain, int k, int start, IList<int> list, IList<IList<int>> result){
        if(remain == 0 && list.Count == k){
            result.Add(new List<int>(list));
            return;
        }
        if(remain < 0 || list.Count > k)
            return;
        
        for(var i = start; i <= 9; i++){
            list.Add(i);
            BacktrackingHelper(remain - i, k, i + 1, list, result);
            list.RemoveAt(list.Count - 1);
        }
    }
}