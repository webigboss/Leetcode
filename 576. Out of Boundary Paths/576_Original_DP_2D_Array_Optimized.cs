public class Solution {
    public int FindPaths(int m, int n, int N, int i, int j) {
        //2D array DP
        //the 3D array can be optimized by Reduction of Dimensionality to 2 2D array;
        //because ik only need ik-1's state
        var dp = new int[m, n];
        //base case 
        dp[i, j] = 1;
        
        var mod = 1000000007;
        var dirs = new []{
            new []{1, 0},
            new []{-1, 0},
            new []{0, 1},
            new []{0, -1}
        };
        
        var result = 0; 
        for(var k = 1; k <= N; ++k){
            var temp = new int[m, n];
            for(var y = 0; y < m; ++y){
                for(var x = 0; x < n; ++x){
                    if(dp[y, x] == 0) continue;
                    foreach(var d in dirs){
                        var ny = y + d[0];
                        var nx = x + d[1];
                        if(ny < 0 || ny >= m || nx < 0 || nx >= n)
                            result = (result + dp[y, x]) % mod; // when stepped out
                        else
                            temp[ny, nx] = (temp[ny, nx] + dp[y, x]) % mod;
                    }
                }
            }
            dp = temp;
        }
        return result;
    }
}