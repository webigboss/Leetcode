public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        //Kahn's algo
        var q = new Queue<int>();
        var edges = new Dictionary<int, IList<int>>();
        var incomingEdges = new int[numCourses];
        //var result = new List<int>();
        foreach(var p in prerequisites){
            incomingEdges[p[0]]++;
            if(!edges.ContainsKey(p[1]))
                edges[p[1]] = new List<int>{ p[0] };
            else
                edges[p[1]].Add(p[0]);
        }
        
        for(var i = 0; i < numCourses; ++i){
            if(incomingEdges[i] == 0) 
                q.Enqueue(i);
        }
        
        while(q.Count > 0){
            var course = q.Dequeue();
            //result.Add(course);
            if(edges.ContainsKey(course)){
                foreach(var next in edges[course]){
                    if(incomingEdges[next] > 0){
                        incomingEdges[next]--;
                        if(incomingEdges[next] == 0)
                            q.Enqueue(next);
                    }
                }
            }
        }
        
        foreach(var i in incomingEdges){
            if(i > 0) return false;
        }
        
        return true;
    }
}