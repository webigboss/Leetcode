public class Solution {
    public int NumFactoredBinaryTrees(int[] A) {
        int mod = (int)1e9 + 7;
        Array.Sort(A);
        var dict = new Dictionary<int, int>();
        for(var i = 0; i < A.Length; ++i)
            dict[A[i]] = i;
        
        var dp = new long[A.Length];
        for(var i = 0; i < A.Length; ++i){
            dp[i] = 1;
            for(var j = 0; j < i; ++j){
                if(A[i]%A[j] != 0) continue;
                var div = A[i]/A[j];
                if(dict.ContainsKey(div)){
                    //Console.WriteLine(dp[j]*dp[dict[div]]);
                    dp[i] = (dp[i] + dp[j]*dp[dict[div]]) % mod;
                }
            }
            //Console.WriteLine($"dp[{i}]:{dp[i]}");
        }
        long ans = 0;
        for(var i = 0; i < dp.Length; ++i){
            ans = (ans + dp[i]) % mod;
        }
        
        return (int)ans;
    }
}