public class Solution {
    public double SoupServings(int N) {
        //DP top down recursion with memo
        if(N > 4800) return 1;
        var n = (N+24)/25;
        var memo = new double[n+1][];
        for(var i = 1; i <= n; ++i)
            memo[i] = new double[n+1];
        return Helper(n, n, memo);
    }
    
    double Helper(int A, int B, double[][] memo){
        //Console.WriteLine($"A:{A}, B:{B}");
        if(A <= 0 || B <= 0){
            if(A <= 0 && B > 0)
                return 1;
            else if(A <= 0 && B <= 0)
                return 0.5;
            else
                return 0;
        }
        if(memo[A][B] > 0) return memo[A][B];
        //Console.WriteLine($"A:{A}, B:{B}");
        
        double ans = 0;
        ans += 0.25 * Helper(A-4, B, memo);
        ans += 0.25 * Helper(A-3, B-1, memo);
        ans += 0.25 * Helper(A-2, B-2, memo);
        ans += 0.25 * Helper(A-1, B-3, memo);
        
        return memo[A][B] = ans;   
    }
}