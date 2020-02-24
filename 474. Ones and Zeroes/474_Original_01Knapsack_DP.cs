public class Solution {
    public int FindMaxForm(string[] strs, int m, int n) {
        //0-1 knapsack solved by DP
        
        //3d array
        var l = strs.Length;
        var dp = new int[l + 1, m + 1, n + 1];
        
        for(var i = 1; i <= l; i++){
            var count = GetCounts(strs[i-1]);
            for(var j = 0; j <= m; j++){
                for(var k = 0; k <= n; k++){
                    if(j >= count[0] && k >= count[1])
                        dp[i, j, k] = Math.Max(dp[i-1, j, k], dp[i-1, j-count[0], k-count[1]] + 1);
                    else
                        dp[i, j, k] = dp[i-1, j, k];
                }
            }
        }
        return dp[l, m, n];
    }
    
    public int[] GetCounts(string s){
        var count = new int[2];
        foreach(var c in s){
            if(c == '0')
                count[0]++;
            else if(c == '1')
                count[1]++;
        }
        return count;
    }
}