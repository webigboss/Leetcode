public class Solution {
    public char FindTheDifference(string s, string t) {
        var charCount = new int[26];
        foreach(char c in s)
            charCount[c - 'a']++;
        foreach(char c in t){
            if(charCount[c - 'a'] == 0)
                return c;
            charCount[c - 'a']--;
        }
        return 'a';
    }
}