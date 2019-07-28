public class Solution {
    public int LongestSubstring(string s, int k) {
        //split s by characters count less than k, recursively pass substring to current method
        if(s.Length < k) return 0;
        var dict = new Dictionary<char, int>();
        var result = 0;
        //one pass, populate character count
        for(var i = 0; i < s.Length; i++){
            if(!dict.ContainsKey(s[i]))
                dict[s[i]] = 1;
            else
                dict[s[i]]++;
        }
        
        var charsLessThanK = new List<char>();
        foreach(var kvp in dict){
            if(kvp.Value < k) charsLessThanK.Add(kvp.Key);
        }
        
        if(charsLessThanK.Count == 0)
            return s.Length;
        
        var subStrs = s.Split(charsLessThanK.ToArray(), StringSplitOptions.RemoveEmptyEntries);
        foreach(var subStr in subStrs){
            result = Math.Max(result, LongestSubstring(subStr, k));
        }
        return result;
    }
}