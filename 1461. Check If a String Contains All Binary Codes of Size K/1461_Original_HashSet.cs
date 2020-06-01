public class Solution {
    public bool HasAllCodes(string s, int k) {
        var cnt = Math.Pow(2, k);
        var str = string.Empty;
        var hs = new HashSet<string>();
        for(var i = 0; i < s.Length; ++i){
            str += s[i];
            if(str.Length == k) {
                hs.Add(str);
                str = str.Substring(1);
            }
        }
        return hs.Count == cnt;
    }
}