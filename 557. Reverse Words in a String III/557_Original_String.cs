public class Solution {
    public string ReverseWords(string s) {
        var list = s.Split(' ');
        var sb = new StringBuilder();
        for(var i = 0; i < list.Length; ++i){
            if(i != 0) sb.Append(' ');
            for(var j = list[i].Length - 1; j >=0; --j){
                sb.Append(list[i][j]);
            }
        }
        return sb.ToString();
    }
}