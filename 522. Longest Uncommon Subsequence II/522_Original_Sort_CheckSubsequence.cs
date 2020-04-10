public class Solution {
    public int FindLUSlength(string[] strs) {
        //sort the array by length descendinly
        if(strs.Length == 0) return -1;
        Array.Sort(strs, (a, b) => b.Length - a.Length);
        for(var i = 0 ; i < strs.Length; ++i){
            var isSubsequence = false;
            for(var j = 0; j < strs.Length; ++j){
                if(j == i) continue;
                isSubsequence = IsSubsequence(strs[i], strs[j]);
                if(isSubsequence) break;
            }
            if(!isSubsequence) return strs[i].Length;
        }
        return -1;
    }
    
    //check if a is subsequence of b
    private bool IsSubsequence(string a, string b){
        if(a.Length > b.Length) return false;
        if(a.Length == b.Length) {
            if(a == b) return true;
            else return false;
        }
        var i = 0;
        foreach(var c in b)
            if(i < a.Length && a[i] == c) i++;
        return i == a.Length;
    }
}