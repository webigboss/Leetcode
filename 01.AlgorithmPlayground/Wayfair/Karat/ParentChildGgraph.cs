using System;
using System.Collections.Generic;

public class ParentChildGraph {
    int[][] testData = new int[][]{ // testData[i][0] is parent of testData[i][1]
        new []{1,4}, new []{1,5}, new []{2,5}, new []{3,6}, new []{6,7}
    };

    public void Test_GetNodesWithZeroOrOneParents(){
        var ans = GetNodesWithZeroOrOneParents(testData);
        Console.WriteLine(string.Join(',', ans));
    }

    public void Test_HaveCommonAncestor(){
        var ans = HaveCommonAncestor(testData, 7, 4);
        Console.WriteLine(ans);
    }

    public int[] GetNodesWithZeroOrOneParents(int[][] graph) {
        var n = graph.Length;
        var inDict = new Dictionary<int, HashSet<int>>();
        for(var i = 0; i < n; ++i){
            int p = graph[i][0], c = graph[i][1];
            if(!inDict.ContainsKey(p))
                inDict[p] = new HashSet<int>();
            if(!inDict.ContainsKey(c))
                inDict[c] = new HashSet<int>();
            inDict[c].Add(p);
        }
        var ans = new List<int>();
        foreach(var kvp in inDict){
            if(kvp.Value.Count <= 1)
                ans.Add(kvp.Key);
        }
        return ans.ToArray();
    }

    public bool HaveCommonAncestor(int[][] graph, int a, int b){
        var inDict = new Dictionary<int, HashSet<int>>();
        for(var i = 0; i < graph.Length; ++i){
            int p = graph[i][0], c = graph[i][1];
            if(!inDict.ContainsKey(p))
                inDict[p] = new HashSet<int>();
            if(!inDict.ContainsKey(c))
                inDict[c] = new HashSet<int>();
            inDict[c].Add(p);
        }
        var aa = GetAncestors(inDict, a);
        var ab = GetAncestors(inDict, b);

        foreach(var ancestor in aa){
            if(ab.Contains(ancestor))
                return true;
        }
        return false;
    }

    HashSet<int> GetAncestors(Dictionary<int, HashSet<int>> inDict, int a){
        var st = new Stack<int>();
        var visited = new HashSet<int>();
        st.Push(a);
        while(st.Count > 0){
            var cur = st.Pop();
            if(visited.Contains(cur)) continue;
            visited.Add(cur);
            foreach(var parent in inDict[cur])
                st.Push(parent);
        }
        visited.Remove(a);
        return visited;
    }
}