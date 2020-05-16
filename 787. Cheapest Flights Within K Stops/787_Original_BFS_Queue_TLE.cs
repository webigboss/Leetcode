public class Solution {
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int K) {
        //BFS with queue
        var q = new Queue<int[]>();
        var dict = new Dictionary<int, List<int[]>>();
        
        foreach(var f in flights){
            if(!dict.ContainsKey(f[0]))
                dict[f[0]] = new List<int[]>();
            dict[f[0]].Add(new []{f[1], f[2]});
        }
        
        q.Enqueue(new[] {src, 0});
        var cnt = q.Count;
        var ans = int.MaxValue;
        while(q.Count > 0){ 
            if(K==-2) break;
            for(var i = 0; i < cnt; ++i){
                var cur = q.Dequeue();
                if(cur[0] == dst){
                    ans = Math.Min(ans, cur[1]);
                    continue;
                }
                if(!dict.ContainsKey(cur[0])) continue;
                foreach(var f in dict[cur[0]]){
                    q.Enqueue(new []{f[0], cur[1] + f[1]});
                }
            }
            
            cnt = q.Count;
            K--;
        }
        return ans == int.MaxValue ? -1 : ans;
    }
}