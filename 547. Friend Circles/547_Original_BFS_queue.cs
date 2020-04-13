public class Solution {
    public int FindCircleNum(int[][] M) {
        //BFS with a queue
        var q = new Queue<int>();
        var N = M.Length;
        var result = 0;
        var visited = new HashSet<int>();
        for(var i = 0; i < N; ++i){
            if(visited.Contains(i)) 
                continue;
            for(var j = 0; j < N; ++j){
                if(M[i][j] == 1){
                    q.Enqueue(j);
                    M[i][j] = 0;
                }
            }
            visited.Add(i);
            while(q.Count > 0){
                var x = q.Dequeue();
                if(visited.Contains(x)) 
                    continue;
                for(var y = 0; y < N; ++y){
                    if(M[x][y] == 1){
                        q.Enqueue(y);
                        M[x][y] = 0;
                    }
                }
                visited.Add(x);
            }
            result++;
        }
        
        return result;
    }
}