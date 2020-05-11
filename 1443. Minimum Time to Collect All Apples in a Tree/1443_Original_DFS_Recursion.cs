public class Solution {
    public int MinTime(int n, int[][] edges, IList<bool> hasApple) {
        var dict = new Dictionary<int, List<int>>();
        foreach(var e in edges){
            if(!dict.ContainsKey(e[0]))
                dict[e[0]] = new List<int>();
            dict[e[0]].Add(e[1]);
        }
        
        var ans = Helper(0, dict, hasApple);
        return ans == 0 ? ans: ans -2;
    }
    
    private int Helper(int cur, Dictionary<int, List<int>> dict, IList<bool> hasApple){
        Console.WriteLine($"enter|cur: {cur}");
        var ans = 0;
        if(dict.ContainsKey(cur)){
            Console.WriteLine($"dict[cur].Count: {dict[cur].Count}");
            foreach(var v in dict[cur]){
                ans += Helper(v, dict, hasApple);
            }
        }
        if(hasApple[cur] || ans > 0)
            ans += 2;
        Console.WriteLine($"exit|cur: {cur}, ans: {ans}");
        return ans;
    }
}