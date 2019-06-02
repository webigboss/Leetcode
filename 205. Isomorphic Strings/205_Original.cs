public class Solution {
    public bool IsIsomorphic(string s, string t) {
        var ans = true;
        var dictS = new Dictionary<char, char>();
        var dictT = new Dictionary<char, char>();
        for(var i = 0; i < s.Length; i++){
            if(dictS.ContainsKey(s[i])){
                if(dictS[s[i]] != t[i])
                    return false;
            }
            else
                dictS.Add(s[i], t[i]);
            
            if(dictT.ContainsKey(t[i])){
                if(dictT[t[i]] != s[i])
                    return false;
            }
            else
                dictT.Add(t[i], s[i]);
        }
        return ans;
    }
}