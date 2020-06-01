public class Solution {
    public int MinReorder(int n, int[][] connections) {
        var dict = new Dictionary<int, List<int[]>>();
        for(var i = 0; i < connections.Length; ++i){
            if(!dict.ContainsKey(connections[i][0]))
                dict[connections[i][0]] = new List<int[]>();
            dict[connections[i][0]].Add(new []{connections[i][1], 1});
            if(!dict.ContainsKey(connections[i][1]))
                dict[connections[i][1]] = new List<int[]>();
            dict[connections[i][1]].Add(new []{connections[i][0], 0});
        }
        
        var ans = new int[1];
        Helper(dict, 0, new HashSet<int>(), ans);
        return ans[0];
    }
    
    void Helper(Dictionary<int, List<int[]>> dict, int cur, HashSet<int> visited, int[] ans){
        if(!dict.ContainsKey(cur) || visited.Contains(cur)) return;
        visited.Add(cur);
        foreach(var pair in dict[cur]){
            if(visited.Contains(pair[0])) continue;
            if(pair[1] == 1) ans[0]++;
            Helper(dict, pair[0], visited, ans);
        }
    }
}