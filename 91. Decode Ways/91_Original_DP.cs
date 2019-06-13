public class Solution {
    public int NumDecodings(string s) {
        //DP Solution
        if(string.IsNullOrEmpty(s))
            return 0;
        var dp = new int[s.Length + 1];
        dp[0] = 1; dp[1] = 1;
        if(s[0] == '0')
            return 0;
        for(var i = 2; i < s.Length + 1; i++){
            if(s[i - 1] == '0'){
                if(s[i - 2] != '1' && s[i - 2] != '2')
                    return 0;
                dp[i] = dp[i - 2];
            }
            else if(s[i - 2] == '2' && s[i - 1] - '0' <= 6 || s[i - 2] == '1')
                dp[i] = dp[i - 1] + dp[i - 2];
            else
                dp[i] = dp[i - 1];
        }
        return dp[s.Length];
    }
}