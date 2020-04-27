public class Solution {
    public string ReplaceWords(IList<string> dict, string sentence) {
        //hash table
        var hs = new HashSet<string>();
        foreach(var d in dict)
            hs.Add(d);
        
        var s = sentence.Split(' ');
        var ans = new List<string>();
        var sb = new StringBuilder();
        for(var i = 0; i < s.Length; ++i){
            sb.Clear();
            foreach(var c in s[i]){
                sb.Append(c);
                if(hs.Contains(sb.ToString()))
                    break;
            }    
            ans.Add(sb.ToString());
        }
        return String.Join(' ', ans);  
    }
}