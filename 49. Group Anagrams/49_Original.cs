public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, IList<string>>();
        var letterCount = new int[26];
        StringBuilder sb = null;
        var dictKey = string.Empty;
        for(var i = 0; i < strs.Length; i++){
            letterCount = new int[26];
            foreach(var c in strs[i]){
                letterCount[c - 'a']++;
            }
            sb = new StringBuilder();
            foreach(var ct in letterCount){
                sb.Append(ct);
            }
            dictKey = sb.ToString();
            if(dict.ContainsKey(dictKey)){
                dict[dictKey].Add(strs[i]);
            }
            else{
                dict.Add(dictKey, new List<string>{ strs[i] });
            }
        }
        return dict.Values.ToList();
    }
}
