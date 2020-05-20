public class Solution {
    public string MostCommonWord(string paragraph, string[] banned) {
        var sb = new StringBuilder();
        var hs = new HashSet<string>();
        var dict = new Dictionary<string, int>();
        foreach(var s in banned)
            hs.Add(s.ToLower());
        
        for(var i = 0; i < paragraph.Length; ++i){
            var c = paragraph[i];
            if(i == paragraph.Length - 1){
                if(c != '?' && c !=',' && c !='!' && c !='\'' && c !=';' && c!='.')
                    sb.Append(c);
                var str = sb.ToString().ToLower();
                sb.Clear();
                if(!string.IsNullOrEmpty(str) && !hs.Contains(str)){
                    if(!dict.ContainsKey(str))
                        dict[str] = 1;
                    else
                        dict[str]++;
                }
                break;
            }
            if(c ==' ' || c == '?' || c==',' || c=='!' || c=='\'' || c==';' || c=='.'){
                var str = sb.ToString().ToLower();
                sb.Clear();
                if(!string.IsNullOrEmpty(str) && !hs.Contains(str)){
                    if(!dict.ContainsKey(str))
                        dict[str] = 1;
                    else
                        dict[str]++;
                }
            }
            else
                sb.Append(c);
        }
        
        var ans = string.Empty;
        var cnt = 0;
        foreach(var kvp in dict){
            //Console.WriteLine($"{kvp.Key}->{kvp.Value}");
            if(kvp.Value > cnt){
                cnt = kvp.Value;
                ans = kvp.Key;
            }
        }
        return ans;
    }
}