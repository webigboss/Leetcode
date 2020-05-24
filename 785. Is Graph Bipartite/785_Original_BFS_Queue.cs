public class Solution {
    public bool IsBipartite(int[][] graph) {
        //color the node approach - BFS
        for(var i = 0; i < graph.Length; ++i){
            if(!BfsHelper(graph, i))
                return false;
        }
        return true;
    }
    
    private bool BfsHelper(int[][] graph, int index){
        var colors = new int[graph.Length]; //red: 1, blue: -1;
        var q = new Queue<int>();
        var cnt = q.Count;
        var isRed = true;
        q.Enqueue(index);
        
        while(q.Count > 0){
            for(var i = 0; i < cnt; ++i){
                var cur = q.Dequeue();
                if(colors[cur] == 1){
                    if(isRed) continue;
                    else return false;
                }
                else if(colors[cur] == -1){
                    if(!isRed) continue;
                    else return false;
                }
                
                colors[cur] = isRed ? 1 : -1;
                
                foreach(var n in graph[cur])
                    q.Enqueue(n);
            }
            cnt = q.Count;
            isRed = !isRed;
        }
        return true;
    }
}