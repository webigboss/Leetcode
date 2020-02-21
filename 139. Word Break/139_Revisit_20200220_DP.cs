public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        var dp = new bool[s.Length + 1];
        //base case. just for keep the ball rolling
        dp[0] = true;
        var hs = new HashSet<string>();
        foreach(var word in wordDict){
            hs.Add(word);
        }
        
        var sb = new StringBuilder();
        for(var i = 0; i < s.Length; i++){
            if(dp[i]){
                sb.Clear();
                for(var j = i; j < s.Length; j++){
                    sb.Append(s[j]);
                    if(hs.Contains(sb.ToString()))
                        dp[j + 1] = true;
                }
            }
        }
        return dp[s.Length];
    }
}