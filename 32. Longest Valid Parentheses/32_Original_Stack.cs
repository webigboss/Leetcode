public class Solution {
    public int LongestValidParentheses(string s) {
        var st = new Stack();
        var length = 0;
        st.Push(-1);
        
        for(var i = 0; i < s.Length; i++){
            if(s[i] == '('){
                st.Push(i);
            }
            else{//s[i]==')'
                st.Pop();
                if(st.Count == 0)
                    st.Push(i);
                else{
                    length = Math.Max(length, i - (int)st.Peek());
                }  
            }
        }
        
        return length;
    }
}