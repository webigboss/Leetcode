public class Solution {
    public int[][] ImageSmoother(int[][] M) {
        var ans = new int[M.Length][];
        for(var i = 0; i < M.Length; ++i){
            ans[i] = new int[M[i].Length];
        }
        
        var directions = new []{
            new []{1,1},
            new []{1,0},
            new []{1,-1},
            new []{0,-1},
            new []{-1,-1},
            new []{-1,0},
            new []{-1,1},
            new []{0,1},
        };
        
        for(var i = 0; i < M.Length; ++i){
            for(var j = 0; j < M[i].Length; ++j){
                var sum = M[i][j];
                var count = 1;
                foreach(var d in directions){
                    var ni = i + d[0];
                    var nj = j + d[1];
                    if(ni >= 0 && ni < M.Length && nj >= 0 && nj < M[0].Length){
                        sum += M[ni][nj];
                        count++;
                    }
                    ans[i][j] = (int)(sum/count);
                }
            }
        }
        return ans;
    }
}