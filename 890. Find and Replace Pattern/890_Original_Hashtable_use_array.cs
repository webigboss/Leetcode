public class Solution {
    public IList<string> FindAndReplacePattern(string[] words, string pattern) {
        var ans = new List<string>();
        for(var i = 0; i < words.Length; ++i){
            if(IsMatchPattern(pattern, words[i]))
                ans.Add(words[i]);
        }
        return ans;
    }
    
    bool IsMatchPattern(string a, string b){
        int n = a.Length;
        var map = new int[26];
        Array.Fill(map, -1);
        var mappedB = new bool[26];
        for(var i = 0; i < n; ++i){
            if(map[a[i]-'a'] == -1){
                if(mappedB[b[i]-'a']) return false;
                map[a[i]-'a'] = b[i]-'a';
                mappedB[b[i]-'a'] = true;
            }
            else{
                if(map[a[i]-'a'] != b[i]-'a') return false;
            }
        }
        return true;
    }
}