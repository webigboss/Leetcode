public class Solution {
    public int CountNumbersWithUniqueDigits(int n) {
        //dp solution
        //dp array to store the unique digits count at n, note it's different from the anwser we want to
        //return, the answer at n should be dp[0]+dp[1]+...+dp[n]
        if(n == 0) return 1;
        if(n == 1) return 10;
        var dp = new int[n + 1];
        //base cases
        //specifically for 0;
        dp[0] = 1;
        //take out case 0 for better form a pattern, it should be 10, but let's consider it's just exclude 0 but only for case from 1 to 9
        dp[1] = 9;
        
        for(var i = 2; i <= n; i++){
            //not hard to come up with this pattern, just think about the all allowing digits at the last place: dp[i - 1] * (10 - (i - 1)) => dp[i - 1] * (11 - i); 
            dp[i] = dp[i - 1] * (11 - i); 
        }
        
        var result = 0;
        for(var i = 0; i < dp.Length; i++)
            result += dp[i];
        return result;
    }
}