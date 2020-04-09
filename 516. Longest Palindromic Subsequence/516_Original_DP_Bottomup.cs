public class Solution {
    public int LongestPalindromeSubseq(string s) {
        //dp bottom up 
        if(string.IsNullOrEmpty(s)) return 0;
        var dp = new int[s.Length, s.Length];
        //base case
        for(var i = 0; i < s.Length; ++i)
            dp[i, i] = 1;
        
        //x is the gap, i is the starting index of first dimension
        //below solution #3 define the dp array differently, with row as the length of string, column as starting index;
        //https://leetcode.com/problems/longest-palindromic-subsequence/discuss/99111/Evolve-from-brute-force-to-dp
        for(var x = 1; x < s.Length; ++x){
            for(var i = 0; i + x < s.Length; ++i){
                dp[i, i + x] = s[i] == s[i + x] ? dp[i + 1, i + x - 1] + 2 
                    : Math.Max(dp[i + 1, i + x], dp[i, i + x - 1]);
            }
        }
        return dp[0, s.Length - 1];
    }
}