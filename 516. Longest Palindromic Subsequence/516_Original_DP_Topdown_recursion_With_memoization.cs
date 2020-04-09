public class Solution {
    public int LongestPalindromeSubseq(string s) {
        //DP top down (recursion + memoization, optimized from pure recursion)
        var memo = new int[s.Length, s.Length];
        return DpHelper(s, 0, s.Length - 1, memo);
    }
    
    private int DpHelper(string s, int lo, int hi, int[,] memo){
        if(lo > hi) return 0;
        if(lo == hi) return 1;
        
        if(memo[lo, hi] > 0) return memo[lo, hi];
        
        var result = s[lo] == s[hi] ? 
            DpHelper(s, lo + 1, hi - 1, memo) + 2 
            : Math.Max(DpHelper(s, lo + 1, hi, memo), DpHelper(s, lo, hi - 1, memo));
        memo[lo, hi] = result;
        return result;
    }
}