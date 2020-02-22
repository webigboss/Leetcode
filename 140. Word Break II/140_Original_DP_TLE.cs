public class Solution {
    public IList<string> WordBreak(string s, IList<string> wordDict) {        
        //DP approach
        var dp = new Dictionary<int, List<string>>();
        dp[0] = new List<string>{ "" };
        var hs = new HashSet<string>();
        foreach(var word in wordDict)
            hs.Add(word);
        var sb = new StringBuilder();
        for(var i = 0; i < s.Length; i++){
            if(dp.ContainsKey(i)){
                sb.Clear();
                for(var j = i; j < s.Length; j++){
                    sb.Append(s[j]);
                    var cur = sb.ToString();
                    if(hs.Contains(cur)){
                        if(!dp.ContainsKey(j + 1))
                            dp[j + 1] = new List<string>();
                        foreach(var prev in dp[i]){
                            dp[j + 1].Add(string.IsNullOrEmpty(prev) ? cur : prev + " " + cur);
                        }
                    }
                }
            }
        }
        return dp.ContainsKey(s.Length) ? dp[s.Length] : new List<string>();
    }
}