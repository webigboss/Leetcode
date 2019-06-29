public class Solution {
    public void ReverseString(char[] s) {
        char temp;
        if(s== null || s.Length == 0) return;
        for(var i = 0; i <= (s.Length - 1) / 2; i++){
            temp = s[i];
            s[i] = s[s.Length - 1 - i];
            s[s.Length - 1 - i] = temp;
        }
    }
}