public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        var dict = new Dictionary<char, int>();
        foreach(var c in magazine){
            if(!dict.ContainsKey(c))
                dict[c] = 1;
            else
                dict[c]++;
        }
        
        foreach(var c in ransomNote){
            if(!dict.ContainsKey(c))
                return false;
            else{
                if(dict[c] == 0) return false;
                dict[c]--;
            }
        }
        return true;
    }
}