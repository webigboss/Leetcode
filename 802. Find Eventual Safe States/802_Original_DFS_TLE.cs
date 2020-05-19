public class Solution {
    public IList<int> EventualSafeNodes(int[][] graph) {
        var circle = new HashSet<int>();
        var visited = new HashSet<int>();
        for(var i = 0; i < graph.Length; ++i){
            if(visited.Contains(i)) continue;
            Console.WriteLine($"i:{i}");
            FindCircle(graph, i, new HashSet<int>(), visited, circle);
        }
        
        var ans = new List<int>();
        for(var i = 0; i < graph.Length; ++i){
            if(!circle.Contains(i))
                ans.Add(i);
        }
        return ans;
    }
    
    void FindCircle(int[][] graph, int index, HashSet<int> hsCur, HashSet<int> visited, HashSet<int> circle){
        if(hsCur.Contains(index)){
            foreach(var i in hsCur)
                circle.Add(i);
            return;
        }
        
        Console.WriteLine($"index:{index}");
        
        visited.Add(index);
        hsCur.Add(index);
        
        foreach(var next in graph[index]){   
            FindCircle(graph, next, hsCur, visited, circle);
        }
        hsCur.Remove(index);
    }
}