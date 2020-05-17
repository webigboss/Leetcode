public class Solution {
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph) {
        var result = new List<IList<int>>();
        if(graph.Length == 0) return result;

        Helper(graph, 0, new List<int>{0}, result);
        return result;
    }
    
    void Helper(int[][] graph, int cur, List<int> list, IList<IList<int>> result){
        if(cur == graph.Length - 1) {
            result.Add(new List<int>(list));
            return;
        }
        
        foreach(var next in graph[cur]){
            list.Add(next);
            Helper(graph, next, list, result);
            list.RemoveAt(list.Count-1);
        }
    }
}