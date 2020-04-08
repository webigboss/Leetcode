public class Solution_Iterative {
    public int Fib(int N) {
        if(N <= 1) return N;
        var n = 2;
        var cur = 0;
        var prev1 = 1;
        var prev2 = 0;
        while(n <= N){
            cur = prev1 + prev2;
            prev2 = prev1;
            prev1 = cur;
            n++;
        }
        
        return cur;
    }
}

public class Solution_Recursive {
    public int Fib(int N) {
        //recursion
        if(N <= 1) return N;
        return Fib(N - 1) + Fib(N - 2); 
    }
}

public class Solution_DP_Top_Down {
    public int Fib(int N) {
        //DP top down (recursion with memoization)
        var memo = new int[N + 1];
        return Helper(N, memo);
    }
    
    public int Helper(int N, int[] memo){
        if(N <= 1) return N;
        if(memo[N] > 0) return memo[N];
        
        var result = Helper(N - 1, memo) + Helper(N - 2, memo);
        memo[N] = result;
        return result;
    }
}

public class Solution_DP_Bottom_Up {
    public int Fib(int N) {
        if(N <= 1) return N;
        //DP bottom up
        var dp = new int[N + 1];
        //base case 
        dp[1] = 1;
        
        for(var i = 2; i <= N; i++){
            dp[i] = dp[i - 2] + dp[i - 1];
        }
        return dp[N];
    }
}
