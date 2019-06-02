public class Solution {
    public bool IsAnagram(string s, string t) {
        var dict = new Dictionary<char, int>();
        foreach(char c in s){
            if(dict.ContainsKey(c)){
                dict[c]++;
            }
            else
                dict.Add(c, 1);
        }
        
        foreach(char c in t){
            if(dict.ContainsKey(c)){
                dict[c]--;
                if(dict[c] == 0)
                    dict.Remove(c);
            }
            else
                return false;
        }
        if(dict.Count > 0)
            return false;
        return true;
    }
}