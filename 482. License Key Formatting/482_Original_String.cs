public class Solution {
    public string LicenseKeyFormatting(string S, int K) {
        //ASCII Code 0-9 48-57 a-z 97-122, A-Z 65-90 
        var sb = new StringBuilder();
        var count = 0;
        for(var i = S.Length - 1; i >= 0; i--){
            if(S[i] == '-') continue;
            if(count == K){
                sb.Append('-');
                count = 0;
            }
            sb.Append(S[i] > 90 ? (char)(S[i] - 32) : (char)S[i]);
            count++;
        }
        
        var charArray = sb.ToString().ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}