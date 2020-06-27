public class Solution {
    public int SubarrayBitwiseORs(int[] A) {
        int n = A.Length;
        var dp = new int[n, n];
        var hs = new HashSet<int>();
        for(var i = 0; i < n; ++i){
            dp[i, i] = A[i];
            hs.Add(dp[i, i]);
        }
        
        for(var i = 1; i < n; ++i) {
            for(var j = i; j < n; ++j){
                dp[j-i, j] = dp[j-i, j-1] | A[j];
                hs.Add(dp[j-i, j]);
            }
        }
        return hs.Count;
    }
}