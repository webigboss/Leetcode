public class Solution {
    public string CustomSortString(string S, string T) {
        var order = new int[26];
        for(var i = 0; i < S.Length; ++i)
            order[S[i]-'a'] = i;
        var arr = T.ToCharArray();
        Array.Sort(arr, (a,b)=>order[a-'a'] - order[b-'a']);
        
        return new string(arr);
    }
}