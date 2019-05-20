public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        //dp solution
        var ht = new Hashtable();
        foreach(var word in wordDict){
            if(ht.Contains(word))
                ht[word] = null;
            else
                ht.Add(word, null);
        }
        var dp = new bool[s.Length + 1];
        //base case
        //although it doesn't make sense to be 'ture', but this is just to make the dp[j] in conditional:
        //dp[j] && ht.Contains(s.Substring(j, i - j)) to be ture so as to keep the ball rolling.
        dp[0] = true; 
        
        for(var i = 1; i <= s.Length; i++){
            for(var j = 0; j < i; j++){
                if(dp[j] && ht.Contains(s.Substring(j, i - j))){
                    dp[i] = true;
                    break;
                }
            }
        }
        
        return dp[s.Length];
    }
}