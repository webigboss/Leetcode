public class Solution {
    public IList<string> StringMatching(string[] words) {
        //sort by length ascendingly
        Array.Sort(words, (a, b) => a.Length - b.Length);
        var result = new List<string>();
        for(var i = 0; i < words.Length; ++i){
            for(var j = i + 1; j < words.Length; ++j){
                if(words[i].Length == words[j].Length) continue;
                if(words[j].Contains(words[i])) {
                    result.Add(words[i]);
                    break;
                }
            }
        }
        return result;
    }
}