public class Solution {
    public IList<bool> CheckIfPrerequisite(int n, int[][] prerequisites, int[][] queries) {
        //Dp with memo
        var dict = new Dictionary<int, List<int>>();
        for(var i =0; i < prerequisites.Length; ++i){
            if(!dict.ContainsKey(prerequisites[i][0]))
                dict[prerequisites[i][0]] = new List<int>();
            dict[prerequisites[i][0]].Add(prerequisites[i][1]);
        }
        var memo = new int[n,n];
        var ans = new List<bool>();
        for(var i = 0; i < queries.Length; ++i){
            ans.Add(DfsHelper(dict, memo, queries[i][0], queries[i][1]));
        }
        return ans;
    }
    
    bool DfsHelper(Dictionary<int, List<int>> dict, int[,] memo, int from, int to){
        if(memo[from, to] == 1) return true;
        else if(memo[from, to] == -1) return false;
        
        var ans = false;
        if(!dict.ContainsKey(from)){ 
            memo[from, to] = -1;
            return false;
        }
        foreach(var cur in dict[from]){
            if(cur == to || DfsHelper(dict, memo, cur, to)) {
                ans = true;
                break;
            }
        }
        memo[from, to] = ans ? 1:-1;
        return ans;
    }
}