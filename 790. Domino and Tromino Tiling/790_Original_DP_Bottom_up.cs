public class Solution {
    public int NumTilings(int N) {
        if(N == 1) return 1;
        if(N == 2) return 2;
        var dp = new long[N+1, 3];
        var mod = (int)1e9 + 7;
        //base case
        dp[1,2] = 1;
        dp[2,0] = 1;
        dp[2,1] = 1;
        dp[2,2] = 2;
        
        for(var i = 3; i <= N; ++i){
            dp[i, 0] = (dp[i-2, 2] + dp[i-1, 1])%mod;
            dp[i, 1] = (dp[i-2, 2] + dp[i-1, 0])%mod;
            dp[i, 2] = (dp[i-1, 2] + dp[i-2, 2] + dp[i-1, 0] + dp[i-1, 1])%mod;
            //Console.WriteLine($"dp[{i},0]->{dp[i,0]};dp[{i},1]->{dp[i,1]};dp[{i},2]->{dp[i,2]};");
        }
        return (int)dp[N, 2];
    }
}