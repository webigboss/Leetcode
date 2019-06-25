public class Solution {
    public IList<int> FindMinHeightTrees(int n, int[][] edges) {
        var dict = new Dictionary<int, HashSet<int>>();
        var result = new List<int>();
        var leaves = new List<int>();
        if(n == 1)
            return new List<int>{ 0 };
        //1. generate dict for all vertices
        for(var i = 0; i < edges.Length; i++){
            if(!dict.ContainsKey(edges[i][0]))
                dict.Add(edges[i][0], new HashSet<int>(new List<int>{edges[i][1]}));
            else{
                if(!dict[edges[i][0]].Contains(edges[i][1]))
                    dict[edges[i][0]].Add(edges[i][1]);
            }
            
            if(!dict.ContainsKey(edges[i][1]))
                dict.Add(edges[i][1], new HashSet<int>(new List<int>{edges[i][0]}));
            else{
                if(!dict[edges[i][1]].Contains(edges[i][0]))
                    dict[edges[i][1]].Add(edges[i][0]);
            }
        }
        //2. leave are vertices with only one edges, get them
        foreach(var v in dict.Keys){
            if(dict[v].Count == 1)
                leaves.Add(v);
        }
        
        //3. trim all the leaves from level by level
        while(n > 2){
            n -= leaves.Count;
            var newLeaves = new List<int>();
            for(var i = 0; i < leaves.Count; i++){
                foreach(var v in dict[leaves[i]]){
                    dict[v].Remove(leaves[i]);
                    if(dict[v].Count == 1)
                        newLeaves.Add(v);
                }
                dict.Remove(leaves[i]);
            }
            leaves = newLeaves;
        }
        
        return leaves;
    }
}