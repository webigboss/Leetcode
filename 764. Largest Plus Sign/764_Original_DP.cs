public class Solution {
    public int OrderOfLargestPlusSign(int N, int[][] mines) {
        var dp = new int[N,N];
        var hsMines = new HashSet<int>();
        foreach(var m in mines)
            hsMines.Add(m[0]*N + m[1]);
        int count;
        var ans = 0;
        for(var c = 0; c < N; ++c){
            //up
            count = 0;
            for(var r = N-1; r >=0; r--){
                count = hsMines.Contains(r*N+c) ? 0 : count + 1;
                dp[r,c] = count;
            }
            //down
            count = 0;
            for(var r = 0; r < N; r++){
                count = hsMines.Contains(r*N+c) ? 0 : count + 1;
                dp[r,c] = Math.Min(dp[r,c], count);
            }
        }
        
        for(var r = 0; r < N; ++r){
            //right
            count = 0;
            for(var c = 0; c < N; ++c){
                count = hsMines.Contains(r*N+c) ? 0 : count + 1;
                dp[r,c] = Math.Min(dp[r,c], count);
            }
            //left
            count = 0;
            for(var c = N-1; c >= 0; --c){
                count = hsMines.Contains(r*N+c) ? 0 : count + 1;
                dp[r,c] = Math.Min(dp[r,c], count);
                ans = Math.Max(ans, dp[r,c]);
            }
        }

        return ans;
    }
}public class Solution {
    public int OrderOfLargestPlusSign(int N, int[][] mines) {
        var dp = new int[N,N];
        var hsMines = new HashSet<int>();
        foreach(var m in mines)
            hsMines.Add(m[0]*N + m[1]);
        int count;
        var ans = 0;
        for(var c = 0; c < N; ++c){
            //up
            count = 0;
            for(var r = N-1; r >=0; r--){
                count = hsMines.Contains(r*N+c) ? 0 : count + 1;
                dp[r,c] = count;
            }
            //down
            count = 0;
            for(var r = 0; r < N; r++){
                count = hsMines.Contains(r*N+c) ? 0 : count + 1;
                dp[r,c] = Math.Min(dp[r,c], count);
            }
        }
        
        for(var r = 0; r < N; ++r){
            //right
            count = 0;
            for(var c = 0; c < N; ++c){
                count = hsMines.Contains(r*N+c) ? 0 : count + 1;
                dp[r,c] = Math.Min(dp[r,c], count);
            }
            //left
            count = 0;
            for(var c = N-1; c >= 0; --c){
                count = hsMines.Contains(r*N+c) ? 0 : count + 1;
                dp[r,c] = Math.Min(dp[r,c], count);
                ans = Math.Max(ans, dp[r,c]);
            }
        }

        return ans;
    }
}public class Solution {
    public int OrderOfLargestPlusSign(int N, int[][] mines) {
        var dp = new int[N,N];
        var hsMines = new HashSet<int>();
        foreach(var m in mines)
            hsMines.Add(m[0]*N + m[1]);
        int count;
        var ans = 0;
        for(var c = 0; c < N; ++c){
            //up
            count = 0;
            for(var r = N-1; r >=0; r--){
                count = hsMines.Contains(r*N+c) ? 0 : count + 1;
                dp[r,c] = count;
            }
            //down
            count = 0;
            for(var r = 0; r < N; r++){
                count = hsMines.Contains(r*N+c) ? 0 : count + 1;
                dp[r,c] = Math.Min(dp[r,c], count);
            }
        }
        
        for(var r = 0; r < N; ++r){
            //right
            count = 0;
            for(var c = 0; c < N; ++c){
                count = hsMines.Contains(r*N+c) ? 0 : count + 1;
                dp[r,c] = Math.Min(dp[r,c], count);
            }
            //left
            count = 0;
            for(var c = N-1; c >= 0; --c){
                count = hsMines.Contains(r*N+c) ? 0 : count + 1;
                dp[r,c] = Math.Min(dp[r,c], count);
                ans = Math.Max(ans, dp[r,c]);
            }
        }

        return ans;
    }
}