public class Solution {
    public string ToGoatLatin(string S) {
        var arr = S.Split(' ');
        var sb = new StringBuilder();
        var vowels = new HashSet<char>{'a', 'o', 'e', 'i', 'u', 'A', 'O', 'E', 'I', 'U'};
        var acnt = 1;
        for(var i = 0; i < arr.Length; ++i){
            var s = arr[i];
            if(string.IsNullOrEmpty(s)) continue;
            if(i != 0) sb.Append(' ');
            if(vowels.Contains(s[0])){
                sb.Append(s);
            }
            else{
                sb.Append(s.Substring(1));
                sb.Append(s[0]);
            }
            sb.Append("ma");
            sb.Append(new string('a', acnt++));
        }
        return sb.ToString();
    }
}