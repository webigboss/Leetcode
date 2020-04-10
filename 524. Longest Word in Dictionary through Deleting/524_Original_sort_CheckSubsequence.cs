public class Solution {
    public string FindLongestWord(string s, IList<string> d) {
        //sort dictionary by length descendinly then lexicographical
        ((List<string>)d).Sort((a, b) =>{
            if(a.Length == b.Length)
                return string.Compare(a, b);
            return b.Length - a.Length;
        });
        for(var i = 0; i < d.Count; ++i){
            if(IsSubsequence(d[i], s))
                return d[i];
        }
        return string.Empty;
    }
    
    //check if a is subsequence of b
    private bool IsSubsequence(string a, string b){
        if(a.Length > b.Length) return false;
        if(a.Length == b.Length){
            if(a == b) return true;
            else return false;
        }
        var i = 0;
        foreach(var c in b){
            if(a[i] == c) i++;
            if(i == a.Length) return true;
        }
        return false;
    }
}