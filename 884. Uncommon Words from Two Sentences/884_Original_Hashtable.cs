public class Solution {
    public string[] UncommonFromSentences(string A, string B) {
        var arrA = A.Split(' ');
        var arrB = B.Split(' ');
        var ans = new List<string>();
        var dictA = new Dictionary<string, int>();
        var dictB = new Dictionary<string, int>();
        foreach(var a in arrA){
            if(string.IsNullOrEmpty(a)) continue;
            if(!dictA.ContainsKey(a))
                dictA[a] = 1;
            else
                dictA[a]++;
        }
        
        foreach(var b in arrB){
            if(string.IsNullOrEmpty(b)) continue;
            if(!dictB.ContainsKey(b))
                dictB[b] = 1;
            else
                dictB[b]++;
        }
        
        foreach(var kvp in dictA){
            if(kvp.Value == 1 && !dictB.ContainsKey(kvp.Key))
                ans.Add(kvp.Key);
        }
        
        foreach(var kvp in dictB){
            if(kvp.Value == 1 && !dictA.ContainsKey(kvp.Key))
                ans.Add(kvp.Key);
        }
        return ans.ToArray();
    }
}