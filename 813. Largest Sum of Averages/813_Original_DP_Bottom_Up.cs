public class Solution {
    public double LargestSumOfAverages(int[] A, int K) {
        //DP bottom up
        var n = A.Length;
        var dp = new double[n, K+1];
        var sumAt = new double[n];
        for(var i = 0; i < n; ++i){
            // Console.WriteLine($"i:{i}");
            if(i == 0) sumAt[0] = A[0];
            else
                sumAt[i] = A[i] +sumAt[i-1];
        }
        
        //base case
        dp[0,1] = 1.0*sumAt[n-1]/n; 
        for(var i = 1; i<n; ++i){
            dp[i,1] = 1.0*(sumAt[n-1] - sumAt[i-1])/(n-i);
            //Console.WriteLine($"dp[{i},1]={dp[i,1]}");
        }
        
        for(var k = 2; k <= K; ++k){
            for(var i = n-1; i >=0; --i){
                var sum = 0;
                for(var j = i+1; j < n; ++j){
                    sum += A[j-1];
                    dp[i,k] = Math.Max(dp[i,k], 1.0*sum / (j-i) + dp[j, k-1]);
                }
                //sum += A[n-1];
                //dp[i,k] = Math.Max(dp[i,k], 1.0*sum/(n-i));
                //Console.WriteLine($"dp[{i},{k}] = {dp[i,k]}");
            }
        }
        
        return dp[0, K];
    }
}