public class Solution {
    public int LeastBricks(IList<IList<int>> wall) {
        if(wall == null || wall.Count == 0) return 0;
        var sum = 0;
        foreach(var b in wall[0])
            sum += b;
        var edges = new Dictionary<long, int>();
        for(var i = 0; i < wall.Count; ++i){
            var curSum = 0;
            //exclude wall[i]'s last element, because edges of wall doesn't count
            for(var j = 0; j < wall[i].Count - 1; ++j){
                curSum += wall[i][j];
                if(!edges.ContainsKey(curSum))
                    edges[curSum] = 1;
                else
                    edges[curSum]++;
            }
        }
        var max = 0;
        foreach(var v in edges.Values){
            max = Math.Max(max, v);
        }
        return wall.Count - max;
    }
}