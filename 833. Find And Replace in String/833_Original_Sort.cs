public class Solution {
    public string FindReplaceString(string S, int[] indexes, string[] sources, string[] targets) {
        var n = indexes.Length;
        var map = new int[n][];
        for(var i = 0; i < n; ++i)
            map[i] = new []{indexes[i], i};
        Array.Sort(map, (a,b) => a[0] - b[0]);
        
        var sb = new StringBuilder();
        var j = 0;
        for(var i = 0; i < S.Length; ++i){
            while(j < map.Length - 1 && map[j][0] < i)
                j++;
            if(map[j][0] == i) {
                var source = sources[map[j][1]];
                var target = targets[map[j][1]];
                if(S.Substring(i, source.Length) == source){
                    sb.Append(target);
                    i += source.Length-1;
                    continue;
                }
            }
            sb.Append(S[i]);
        }
        return sb.ToString();
    }
}