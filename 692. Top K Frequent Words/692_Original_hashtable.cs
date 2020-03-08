public class Solution {
    public IList<string> TopKFrequent(string[] words, int k) {
        //
        var dict = new Dictionary<string, int>();
        foreach(var w in words){
            if(!dict.ContainsKey(w))
                dict[w] = 1;
            else 
                dict[w]++;
        }
        
        var list = dict.ToList();
        list.Sort((a, b) => {
            if(a.Value == b.Value){
                return a.Key.CompareTo(b.Key);
            }
            return b.Value - a.Value;
        });
        
        var result = new List<string>();
        var c = Math.Min(k, list.Count);
        for(var i = 0; i < c; i++){
            result.Add(list[i].Key);
        }
        return result;
    }
}