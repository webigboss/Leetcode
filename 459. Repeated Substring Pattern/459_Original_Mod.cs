public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        //brute force
        if(s == null || s.Length < 2) return false;
        var matchFailed = false;
        for(var l = 1; l <= s.Length / 2 + 1; l++) {
            if(s.Length % l != 0 || s.Length == l) continue;
            matchFailed = false;
            for(var i = 0; i < s.Length; i++) {
                if(s[i] != s[i % l]){
                    matchFailed = true;
                    break;
                }
            }
            if(matchFailed == true) continue;
            return true;
        }
        return false;
    }
}