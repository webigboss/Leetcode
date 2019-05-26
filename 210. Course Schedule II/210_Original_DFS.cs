public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        //DFS solution
        var result = new int[numCourses];
        var st = new Stack<int>();
        var edges = new Dictionary<int, IList<int>>();
        var visited = new HashSet<int>();
        var curPath = new HashSet<int>();
        foreach(var i in prerequisites){
            if(edges.ContainsKey(i[1]))
                edges[i[1]].Add(i[0]);
            else
                edges.Add(i[1], new List<int>{ i[0] });
        }

        for(var i = 0; i < numCourses; i++){
            if(!DfsHelper(i, edges, visited, curPath, st))
                return new int[0];
        }
        var j = 0;
        while(st.Count > 0){
            result[j++] = st.Pop();
        }
        return result;
    }
    
    private bool DfsHelper(int num, Dictionary<int, IList<int>> edges, HashSet<int> visited, 
                           HashSet<int> curPath, Stack<int> st){
        if(curPath.Contains(num)){
            return false;
        }
        if(visited.Contains(num))
            return true;
        
        visited.Add(num);
        curPath.Add(num);
        
        if(edges.ContainsKey(num)){
            foreach(var next in edges[num]){
                if(!DfsHelper(next, edges, visited, curPath, st))
                    return false;
            }
        }
        st.Push(num);
        curPath.Remove(num);
        return true;
    }
}