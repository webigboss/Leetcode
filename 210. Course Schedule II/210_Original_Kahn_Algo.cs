public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        //kahn's algorithm with stack as the data structure
        
        var result = new int[numCourses];
        var st = new Stack<int>();
        var incomingCount = new int[numCourses];
        var edges = new Dictionary<int, List<int>>();
        
        //1. prepare edges dictionary and incomingCount array
        for(var i = 0; i < prerequisites.Length; i++){
            incomingCount[prerequisites[i][0]]++;
            if(edges.ContainsKey(prerequisites[i][1]))
                edges[prerequisites[i][1]].Add(prerequisites[i][0]);
            else
                edges.Add(prerequisites[i][1], new List<int>{ prerequisites[i][0] });
        }
        
        //2. initialize starting vertices into the stack
        for(var i = 0; i < incomingCount.Length; i++){
            if(incomingCount[i] == 0)
                st.Push(i);
        }
        
        //3. start delete vertices and outwards edges and push new vertex that doesn't have incoming edges
        // resulted by deletion of previous vertex
        var j = 0;
        while(st.Count > 0){
            var num = st.Pop();
            result[j++] = num;
            if(edges.ContainsKey(num)){
                foreach(var next in edges[num]){
                    incomingCount[next]--;
                    if(incomingCount[next] == 0)
                        st.Push(next);
                }
            }
        }
        
        //4. check if the graph has cycle, (not directed acyclic graph (DAG))
        for(var i = 0; i < incomingCount.Length; i++){
            if(incomingCount[i] > 0)
                return new int[0];
        }
        return result;
    }
}