public class Solution {
    public int[] CountBits(int num) {
        // DP approach
        if(num == 0)
            return new int[1];
        
        var dp = new int[num + 1];
        //base cases
        dp[1] = 1;
        //1. populate all the power of 2 that are less then num with value 1 because they will only have 1 '1'. e.g. 8= 1000, 16 = 10000... 
        //by bitshift to left
        var step = 1;
        while(1 << step <= num){
            dp[1 << step++] = 1;
        }
        
        
        //2. divide the range by powers of 2, divide main problem into sub-problems,
        //dp formula is dp[i] = dp[curPower] + dp[i - curPower];
        step = 0;
        int curPower = 0;
        for(var i = 2; i <= num; i++){
            if(dp[i] == 1){
                step = 0;
                curPower = i;
                continue;
            }
            dp[i] = dp[curPower] + dp[i - curPower];
        }        
        return dp;
    }
}