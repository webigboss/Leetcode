public class Solution {
    public int LongestValidParentheses(string s) {
        // DP solution
        if(string.IsNullOrEmpty(s) || s.Length == 1)
            return 0;
        var dp = new int[s.Length];
        dp[0] = 0;
        dp[1] = s[0] == '(' && s[1] == ')' ? 2 : 0;
        var result = dp[1];
        for(var i = 2; i < s.Length; i++){
            if(s[i] == '(')
                continue;
            else{ //s[i] ==')'
                if(s[i - 1] == '(')
                    dp[i] = dp[i - 2] + 2;
                else{ // s[i - 1] = ')'
                    if(i - dp[i - 1] - 1 >= 0 && s[i - dp[i - 1] - 1] == '('){
                        dp[i] = dp[i - 1] + 2 + (i - dp[i - 1] - 2 > 0 ? dp[i - dp[i - 1] - 2] : 0);
                    }
                }
            }
            result = Math.Max(result, dp[i]);
        }
        
        return result;
    }
}