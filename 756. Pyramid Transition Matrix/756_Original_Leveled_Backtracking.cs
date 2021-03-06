public class Solution {
    public bool PyramidTransition(string bottom, IList<string> allowed) {
        var dict = new Dictionary<string, List<char>>();
        foreach(var a in allowed){
            var key = a.Substring(0,2);
            if(!dict.ContainsKey(key))
                dict[key] = new List<char>();
            dict[key].Add(a[2]);
        }
        return Helper(bottom, 1, string.Empty, dict);
    }
    
    private bool Helper(string cur, int i, string next, Dictionary<string, List<char>> dict){
        if(cur.Length == 1) return true;
        
        var key = new string(new []{cur[i-1], cur[i]});
        
        if(!dict.ContainsKey(key)) return false;
        
        foreach(var c in dict[key]){
            if(i == cur.Length - 1){
                if(Helper(next+c, 1, string.Empty, dict))
                    return true;
            }
            else{
                if(Helper(cur, i+1, next+c, dict))
                    return true;
            }
        }
        
        return false;
    }
}