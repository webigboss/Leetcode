public class Solution {
    public int TitleToNumber(string s) {
        int result = 0;
        for(var i = s.Length - 1; i >= 0; i--){
            result += (s[i] - 'A' + 1) * (int)Math.Pow(26, s.Length - 1 - i);
        }
        
        return result;
    }
}