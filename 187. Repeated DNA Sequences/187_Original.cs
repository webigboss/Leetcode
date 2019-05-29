public class Solution {
    public IList<string> FindRepeatedDnaSequences(string s) {
        var dict = new Dictionary<string, int>();
        var result = new List<string>();
        for(var i = 0; i < s.Length - 9; i++){
            var sub = s.Substring(i, 10);
            if(dict.ContainsKey(sub)){
                if(dict[sub] == 1)
                    result.Add(sub);
                dict[sub]++;
            }
            else
                dict.Add(sub, 1);
        }
        
        return result;
    }
}