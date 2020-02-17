public class Solution {
    public int FindSubstringInWraproundString(string p) {
        if(string.IsNullOrEmpty(p)) return 0;
        var hs = new HashSet<string>();
        var sb = new StringBuilder();
        for(var i = 0; i < p.Length; i++){
            sb.Clear();
            for(var j = i; j < p.Length; j++){
                if(j > i){
                    if(p[j] - p[j - 1] != 1 && !(p[j] == 'a' && p[j - 1] == 'z'))
                        break;
                }
                sb.Append(p[j]);
                var subString = sb.ToString();
                if(!hs.Contains(subString))
                    hs.Add(subString);
            }     
        }
        return hs.Count;              
    }
}