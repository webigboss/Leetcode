public class Solution {
    public string DestCity(IList<IList<string>> paths) {
        var hs = new HashSet<string>();
        
        foreach(var p in paths){
            hs.Add(p[0]);
        }
        var ans = string.Empty;
        foreach(var p in paths){
            if(!hs.Contains(p[1])){
                ans = p[1];
                break;
            }
        }
        return ans;
    }
}