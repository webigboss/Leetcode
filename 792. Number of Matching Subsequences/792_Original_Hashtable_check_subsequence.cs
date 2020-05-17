public class Solution {
    public int NumMatchingSubseq(string S, string[] words) {
        var dict = new Dictionary<string, int>();
        foreach(var w in words){
            if(!dict.ContainsKey(w))
                dict[w] = 1;
            else
                dict[w]++;
        }
        var ans = 0;
        foreach (var kvp in dict){
            if(IsSubsequence(kvp.Key, S)) ans += kvp.Value;
        }
        return ans;
    }
    
    //check if a is a subsequence of b
    private bool IsSubsequence(string a, string b){
        if(a.Length > b.Length) return false;
        if(a.Length == b.Length){
            if(a == b) return true;
            else return false;
        }
        var i = 0;
        foreach(var c in b){
            if(i == a.Length) return true;
            if(a[i] == c) i++;
        }
        return i == a.Length;
    }
}