public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        // topological sort, Kahn's algorithm approach, inspired by https://en.wikipedia.org/wiki/Topological_sorting

        //queue of all vertices that don't have incoming edge, could be any set data structure like list or stack
        //the order of getting out the vertex will make the final order result different, because topological sort is not unique
        var q = new Queue<int>();
        //this is the ordered result list, in this case it's not necessary
        //I left it here anyway just for you to understand in case we are asked to get a viable solution
        var orderdResult = new List<int>();
        //since the value of each vertices is int and is from [0 - numCourses - 1], we can just this int array to memorize the counter;
        //generically we can use Hashtable or Dictionary<>
        var incomingEdgeCount = new int[numCourses];
        //1. find the incoming edges count for each courses
        foreach(var e in prerequisites){
            incomingEdgeCount[e[0]]++;
        }
        //2. find those starting vertex that without incoming edges
        for(var i = 0; i < incomingEdgeCount.Length; i++){
            if(incomingEdgeCount[i] == 0)
                q.Enqueue(i);
        }
        //3. find all edges 
        var edges = new Dictionary<int, List<int>>();
        foreach(var edge in prerequisites){
            if(edges.ContainsKey(edge[1]))
                edges[edge[1]].Add(edge[0]);
            else
                edges.Add(edge[1], new List<int>(){ edge[0] });
        }
        //4. keep add and removing vertices when it doesn't have incoming edges
        while(q.Count > 0){
            var v = q.Dequeue();
            orderdResult.Add(v);
            if(edges.ContainsKey(v)){
                foreach(var next in edges[v]){
                    if(incomingEdgeCount[next] > 0){
                        incomingEdgeCount[next]--;
                        if(incomingEdgeCount[next] == 0)
                            q.Enqueue(next);
                    }  
                }
            }
        }
        
        //5. validate if it's a directed acyclic graph, it's a DAG when there is no edges left.
        foreach(var count in incomingEdgeCount){
            if(count > 0)
                return false;
        }
        return true;
    }
}