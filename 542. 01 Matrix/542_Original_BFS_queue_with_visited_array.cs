public class Solution {
    public int[][] UpdateMatrix(int[][] matrix) {
        //BFS using queue
        var q = new Queue<int[]>();
        var result = new int[matrix.Length][];
        for(var i = 0; i < result.Length; ++i)
            result[i] = new int[matrix[0].Length];
        
        var neighbours = new []{
            new []{1, 0},
            new []{-1, 0},
            new []{0, 1},
            new []{0, -1}
        };
        
        for(var i = 0; i < matrix.Length; ++i){
            for(var j = 0; j < matrix[0].Length; ++j){
                if(matrix[i][j] == 0) continue;
                var minDistance = int.MaxValue;
                q.Clear();
                q.Enqueue(new []{i, j, 0});
                var visited = new bool[matrix.Length, matrix[0].Length];
                while(q.Count > 0){
                    var item = q.Dequeue();
                    var r = item[0];
                    var c = item[1];
                    var d = item[2];
                    if(visited[r,c]) continue;
                    if(d >= minDistance) continue;
                    visited[r,c] = true;
                    //remove re-adding calculated element into the queue
                    if(matrix[r][c] == 0){
                        minDistance = Math.Min(minDistance, d);
                        continue;
                    }
                    foreach(var n in neighbours){
                        if(r + n[0] >= 0 && r + n[0] < matrix.Length 
                           && c + n[1] >= 0 && c + n[1] < matrix[0].Length){
                            q.Enqueue(new []{r+n[0], c+n[1], d + 1});
                        }
                    }
                }
                result[i][j] = minDistance;
            }
        }
        return result;
    }
}