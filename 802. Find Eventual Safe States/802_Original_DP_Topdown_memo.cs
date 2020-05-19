public class Solution {
    public IList<int> EventualSafeNodes(int[][] graph) {
        //DP top down with memo
        var color = new int[graph.Length]; //0 unvisited, 1, visited and safe, 2, visited but unsafe(within a circle)
        
        for(var i = 0; i < graph.Length; ++i){
            DfsHelper(graph, i, color);
        }
        
        var ans = new List<int>();
        for(var i = 0; i < color.Length; ++i){
            if(color[i] != 2) 
                ans.Add(i);
        }
        return ans;
    }
    
    bool DfsHelper(int[][] graph, int k, int[] color){
        if(color[k] != 0) return color[k] == 1;
        
        color[k] = 2;
        for(var i = 0; i < graph[k].Length; ++i){
            if(!DfsHelper(graph, graph[k][i], color)) return false;
        }
        color[k] = 1;
        return true;
    }
}