public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
        //combination result of k out of n
        var result = new List<IList<int>>();
        
        CombinationBacktracking(n, k, 1, new List<int>(), result);
        return result;
    }
    
    private void CombinationBacktracking(int n, int k, int start, IList<int> list, IList<IList<int>> result){
        if(list.Count == k){
            result.Add(new List<int>(list));
            return;
        }
        
        for(var i = start; i <= n; i++){
            list.Add(i);
            CombinationBacktracking(n, k, i + 1, list, result);
            list.RemoveAt(list.Count - 1);
        }
    }
}