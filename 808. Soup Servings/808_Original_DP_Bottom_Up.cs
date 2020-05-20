public class Solution {
    public double SoupServings(int N) {
        //DP bottom up
        if(N > 4800) return 1;
        var n = (N+24)/25;
        var dp = new double[n+1,n+1];
        //base case
        dp[0, 0] = 0.5;
        for(var j = 1; j <= n; ++j){
            dp[0, j] = 1;
        }
        
        
        for(var i =1; i <= n; ++i){
            for(var j = 1; j <= n; ++j){
                dp[i,j] = 0.25*( dp[i-4<0?0:i-4, j] + dp[i-3<0?0:i-3, j-1<0?0:j-1] + dp[i-2<0?0:i-2, j-2<0?0:j-2] + dp[i-1<0?0:i-1, j-3<0?0:j-3]);  
                //Console.WriteLine($"dp[{i}{j}]={dp[i,j]}");
            } 
        }
        return dp[n,n];
    }
}