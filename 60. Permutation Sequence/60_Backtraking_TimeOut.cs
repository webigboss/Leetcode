public class Solution {
    public string GetPermutation(int n, int k) {
        var permutations = new List<IList<int>>();
        BacktrackingHelper(n, new List<int>(), k, permutations);
        var sb = new StringBuilder();
        foreach(var c in permutations[k - 1]){
            sb.Append(c);
        }
        return sb.ToString();
    }
    
    private void BacktrackingHelper(int n, IList<int> list, int target, IList<IList<int>> p){
        if(list.Count == n)
            p.Add(new List<int>(list));
        
        if(p.Count == target)
            return;
        
        for(var i = 1; i <= n; i++){
            if(list.Contains(i))
                continue;
            list.Add(i);
            BacktrackingHelper(n, list, target, p);
            list.RemoveAt(list.Count - 1);    
        }
    }
}