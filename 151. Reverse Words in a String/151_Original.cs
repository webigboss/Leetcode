public class Solution {
    public string ReverseWords(string s) {
        var sb = new StringBuilder();
        var st = new Stack();
        foreach(char c in s){
            if(c == ' '){
                if(sb.Length > 0)
                    st.Push(sb.ToString());
                sb.Clear();
            }
            else
                sb.Append(c);
        }
        if(sb.Length > 0)
            st.Push(sb.ToString());
        sb.Clear();
        while(st.Count > 0){
            if(st.Count == 1)
                sb.Append((string)st.Pop());
            else
                sb.Append((string)st.Pop() + " ");
        }
        return sb.ToString();
    }
}