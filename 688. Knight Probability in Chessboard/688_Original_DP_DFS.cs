public class Solution {
    public double KnightProbability(int N, int K, int r, int c) {
        //DP + DFS
        if(K == 0) return 1;
        var board = new double[N, N];
        var q = new Queue<int[]>();
        var q2 = new Queue<double>();
        q.Enqueue(new int[]{r, c});
        q2.Enqueue(1);
        
        var directions = new []{
            new []{2,1},
            new []{1,2},
            new []{-1,2},
            new []{-2,1},
            new []{-2,-1},
            new []{-1,-2},
            new []{1,-2},
            new []{2,-1}
        };
        var k = K;
        while(k > 0){
            for(var i = 0; i < N; ++i){
                for(var j = 0; j < N; ++j){
                    if(board[i, j] == 0) continue;
                    q.Enqueue(new []{i, j});
                    q2.Enqueue(board[i,j]);
                    board[i,j] = 0;
                }
            }
            
            while(q.Count > 0){
                var item = q.Dequeue();
                var nr = item[0];
                var nc = item[1];
                var cnt = q2.Dequeue();
                
                foreach(var d in directions){
                    var dr = d[0];
                    var dc = d[1];
                    if(nr+dr>=0 && nr+dr<N && nc+dc>=0 && nc+dc<N){
                        board[nr+dr,nc+dc] += cnt;
                    }
                }
            }
            k--;
        }
        
        double ans = 0;
        for(var i = 0; i < N; ++i){
            for(var j = 0; j < N; ++j){
                ans += board[i,j];
            }
        }
        //return ans;
        return ans/Math.Pow(8,K);
    }
}