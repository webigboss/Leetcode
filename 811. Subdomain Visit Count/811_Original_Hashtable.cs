public class Solution {
    public IList<string> SubdomainVisits(string[] cpdomains) {
        var dict = new Dictionary<string, int>();
        
        foreach(var d in cpdomains){
            var p = d.Split(' ');
            var arr = p[1].Split('.');
            var c = int.Parse(p[0]);
            var cur = string.Empty;
            for(var i = arr.Length-1; i >=0; --i){
                var next = cur == string.Empty ? arr[i] : arr[i]+'.'+cur;
                if(!dict.ContainsKey(next))
                    dict[next] = c;
                else
                    dict[next] += c;
                cur = next;
            }
        }
        
        var ans = new List<string>();
        
        foreach(var kvp in dict){
            ans.Add(kvp.Value.ToString() + " " + kvp.Key);
        }
        
        return ans;
    }
}