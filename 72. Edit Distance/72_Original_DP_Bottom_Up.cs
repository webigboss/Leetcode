public class Solution {
    public int MinDistance(string word1, string word2) {
        //DP bottom-up
        var l1 = word1.Length;
        var l2 = word2.Length;
        
        //not necessary but it's just a small optimization
        if(l1 == 0) return l2;
        if(l2 == 0) return l1;
        
        //dp[i,j] the min edit for word1 ends with index i, word2 ends with index j
        var dp = new int[l1 + 1, l2 + 1];
        
        //base case;
        for(var i = 0; i <= l1; ++i)
            dp[i, 0] = i;
        for(var j = 0; j <= l2; ++j)
            dp[0, j] = j;
        
        for(var i = 1; i <= l1; ++i){
            for(var j = 1; j <= l2; ++j){
                if(word1[i-1] == word2[j-1])
                    dp[i, j] = dp[i-1, j-1];
                else{
                    dp[i, j] = Math.Min(dp[i-1, j-1]+1, Math.Min(dp[i-1, j]+1, dp[i, j-1]+1));   
                }
            }
        }
        return dp[l1, l2];
    }
}