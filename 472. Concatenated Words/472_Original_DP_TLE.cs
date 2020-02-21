public class Solution {
    public IList<string> FindAllConcatenatedWordsInADict(string[] words) {
        var hs = new HashSet<string>();
        foreach(var word in words)
            hs.Add(word);
        var result = new List<string>();
        
        foreach(var word in words){
            hs.Remove(word);
            if(IsConcat(word, hs))
                result.Add(word);
            hs.Add(word);
        }
        return result;
    }
    
    //same as LC 139 word break
    private bool IsConcat(string s, HashSet<string> hs){
        if(string.IsNullOrEmpty(s)) return false;
        var dp = new bool[s.Length + 1];
        dp[0] = true; //base case
        var sb = new StringBuilder();
        for(var i = 0; i < s.Length; i++){
            if(dp[i]){
                sb.Clear();
                for(var j = i; j < s.Length; j++){
                    sb.Append(s[j]);
                    if(hs.Contains(sb.ToString())){
                        dp[j + 1] = true;
                    }
                }
            }
        }
        return dp[s.Length];
    }
}