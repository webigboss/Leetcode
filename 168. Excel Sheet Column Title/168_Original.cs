public class Solution {
    public string ConvertToTitle(int n) {
        var st = new Stack();
        var sb = new StringBuilder();
        int remainder = 0;
        while(n != 0){
            remainder = n % 26;
            if(remainder == 0){
                st.Push('Z');
                n = n / 26 - 1;
            }
            else{
                st.Push((char)('A' + remainder - 1));
                n = n / 26;
            }

        }
        
        while(st.Count > 0){
            sb.Append((char)st.Pop());
        }
        
        return sb.ToString();
    }
}