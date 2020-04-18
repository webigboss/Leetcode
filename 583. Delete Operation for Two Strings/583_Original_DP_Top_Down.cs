public class Solution {
    public int MinDistance(string word1, string word2) {
        //DP top down
        return Helper(word1, word1.Length - 1, word2, word2.Length - 1, new int[word1.Length, word2.Length]);
    }
    
    private int Helper(string word1, int i1, string word2, int i2, int[,] memo){
        if(i1 == -1) return i2 + 1;
        if(i2 == -1) return i1 + 1;
        if(memo[i1, i2] != 0) return memo[i1, i2];
        
        var result = int.MaxValue;
        if(word1[i1] == word2[i2])
            result = Helper(word1, i1 - 1, word2, i2 - 1, memo);
        else{
            result = Math.Min(Helper(word1, i1, word2, i2 - 1, memo) + 1,
                             Helper(word1, i1 - 1, word2, i2, memo) + 1);
            result = Math.Min(result, Helper(word1, i1 - 1, word2, i2 - 1, memo) + 2);
        }
        
        memo[i1, i2] = result;
        return result;
    }
}