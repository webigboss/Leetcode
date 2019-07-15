public class Solution {
    public int FirstUniqChar(string s) {
        var charCount = new int[26];
        for(var i = 0; i < s.Length; i++)
            charCount[s[i] - 'a']++;
        for(var i = 0; i < s.Length; i++){
            if(charCount[s[i] - 'a'] == 1)
                return i;
        }
        return -1;
    }
}