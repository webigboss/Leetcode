public class Solution {
    public double New21Game(int N, int K, int W) {
        double m = 1e-5;
        //return 1;
        if(K == 0) return 1;
        if(N == 0) return 0; 
        var dp = new double[N+1];
        for(var i = 1; i <= Math.Min(W,N); ++i)
            dp[i] = 1.0/W;
        var min = 1;
        while(min < K){
            //var 
            for(var i = min+1; i <= Math.Min(min+W, N); ++i){
                dp[i] += dp[min]/W;
                //Console.WriteLine($"dp[{i}]={dp[i]}");
            }
            dp[min] = 0;
            min++;
        }
        
        double ans = 0;
        foreach(var d in dp){
            // Console.WriteLine(d);
            ans += d;
        }
        return ans;
    }
}