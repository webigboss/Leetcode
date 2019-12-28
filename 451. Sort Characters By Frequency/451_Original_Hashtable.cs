public class Solution {
    public string FrequencySort(string s) {
        //hashtable approach
        var dict = new Dictionary<char, int>();
        var maxCount = 0;
        var sb = new StringBuilder();
        foreach(var c in s) {
            if(!dict.ContainsKey(c)) {
                dict[c] = 1;
            }
            else {
                dict[c]++;
            }
            maxCount = Math.Max(maxCount, dict[c]);
        }
        
        while(maxCount > 0) {
            foreach(var kvp in dict) {
                if(kvp.Value == maxCount) {
                    sb.Append(kvp.Key, kvp.Value);
                }
            }
            maxCount--;
        }
        return sb.ToString();
    }
}