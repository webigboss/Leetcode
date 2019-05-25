public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        // DFS solution, inspired by https://www.youtube.com/watch?v=Q9PIxaNGnig 
        var st = new Stack<int>();
        var visited = new HashSet<int>();
        var dict = new Dictionary<int, IList<int>>();
        foreach(var arr in prerequisites){
            if(dict.ContainsKey(arr[1]))
                dict[arr[1]].Add(arr[0]);
            else
                dict.Add(arr[1], new List<int> { arr[0] });
        }
        
        for(var i = 0; i < numCourses; i++){
            //memorize current path, used to identify if current graph is not a Directed Acyclic Graph 
            var cur = new HashSet<int>();
            if(!DfsHelper(i, dict, visited, cur, st))
                return false;
        }
        return st.Count == numCourses;
    }
    
    private bool DfsHelper(int num, Dictionary<int, IList<int>> dict, HashSet<int> visited, HashSet<int> cur, Stack<int> st){
        if(cur.Contains(num))
            return false;
        cur.Add(num);
        
        if(visited.Contains(num)){
            //prevent current path being polluted by other recursion sub tree, current vertex will be removed
            cur.Remove(num);
            return true;
        }
        visited.Add(num);
        
        if(dict.ContainsKey(num)){
            foreach(var next in dict[num]){
                // if sub recursion is false will directly return false all the way up, indicating a cycle is found (not a DAG)
                if(!DfsHelper(next, dict, visited, cur, st))
                    return false;
            }
        }
        st.Push(num);
        //prevent current path being polluted by other recursion sub tree, current vertex will be removed
        cur.Remove(num);
        return true;
    }
}