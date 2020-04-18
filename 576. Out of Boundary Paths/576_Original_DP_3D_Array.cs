public class Solution {
    public int FindPaths(int m, int n, int N, int i, int j) {
        //3D array DP, dp[im, in, ik], ik is the ikth move, visit count of (im, in) 
        //the 3D array can be optimized by Reduction of Dimensionality to 2 2D array;
        //because ik only need ik-1's state
        var dp = new int[m, n, N + 1];
        //base case 
        dp[i, j, 0] = 1;
        
        var mod = 1000000007;
        var dirs = new []{
            new []{1, 0},
            new []{-1, 0},
            new []{0, 1},
            new []{0, -1}
        };
        
        var result = 0; 
        for(var k = 1; k <= N; ++k){
            for(var y = 0; y < m; ++y){
                for(var x = 0; x < n; ++x){
                    if(dp[y, x, k-1] == 0) continue;
                    foreach(var d in dirs){
                        var ny = y + d[0];
                        var nx = x + d[1];
                        if(ny < 0 || ny >= m || nx < 0 || nx >= n)
                            result = (result + dp[y, x, k-1]) % mod; // when stepped out
                        else
                            dp[ny, nx, k] = (dp[ny, nx, k] + dp[y, x, k-1]) % mod;
                    }
                }
            }
        }
        return result;
    }
}