public class Solution {
    public NestedInteger Deserialize(string s) {
        var st = new Stack<NestedInteger>();
        var sb = new StringBuilder();
        NestedInteger result = null;
        for(var i = 0; i < s.Length; i++){
            if(s[i] == '['){
                st.Push(new NestedInteger());
            }
            else if(Char.IsDigit(s[i]) || s[i] == '-'){
                sb.Append(s[i]);
            }
            else if(s[i] == ',' && sb.Length > 0){
                var num = int.Parse(sb.ToString());
                sb.Clear();
                st.Peek().Add(new NestedInteger(num));
            }
            else if(s[i] == ']'){
                if(sb.Length > 0){
                    var num = int.Parse(sb.ToString());
                    sb.Clear();
                    st.Peek().Add(new NestedInteger(num));
                }
                var nint = st.Pop();
                if(st.Count == 0) {
                    result = nint;
                    break;
                }               
                st.Peek().Add(nint);
            }
        }
        
        if(sb.Length > 0){
            var num = int.Parse(sb.ToString());
            return new NestedInteger(num);
        }
        return result;
    }
}