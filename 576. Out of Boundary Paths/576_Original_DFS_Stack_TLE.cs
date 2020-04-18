public class Solution {
    public int FindPaths(int m, int n, int N, int i, int j) {
        //DFS iterative with a stack
        // only difference is we don't need to have record visited, it's allowed to revisit
        // a cell as many time as we can as long as we still have move left

        //dp[i,j]: visit count of cell at (i,j), the answer will be the sum of the counts of boundary cells
        var dp = new int[m, n];
        var st = new Stack<int[]>();
        var mod = 1000000007;
        var neighbours = new []{
            new []{1, 0},
            new []{-1, 0},
            new []{0, 1},
            new []{0, -1}
        };
        st.Push(new []{i, j, N});

        while(st.Count > 0){
            var item = st.Pop();
            var r = item[0];
            var c = item[1];
            var moves = item[2];
            if(moves == 0) continue;
            dp[r, c]++;
            if(dp[r, c] > mod)
                dp[r, c] %= mod;
            foreach(var nb in neighbours){
                if(r + nb[0] >=0 && r + nb[0] < m && c + nb[1] >= 0 && c + nb[1] < n){
                    st.Push(new []{r+nb[0], c+nb[1], moves-1});
                }
            }
        }
        
        var result = 0;
        //calculate result by 4 boundary
        //top and bottom
        for(var k = 0; k < n; ++k){
            result += dp[0, k];
            result %= mod;
            result += dp[m-1, k];
            result %= mod;
        }
        //left and right
        for(var k = 0; k < m; ++k){
            result += dp[k, 0];
            result %= mod;
            result += dp[k, n-1];
            result %= mod;
        }
        return result;
    }
}