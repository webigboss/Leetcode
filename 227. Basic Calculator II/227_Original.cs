public class Solution {
    public int Calculate(string s) {
        var st = new Stack<int>();
        int num = 0;
        char opr = '+';
        for(var i = 0; i < s.Length; i++){
            if(Char.IsDigit(s[i])){
                num = num * 10 + (s[i] - '0');
            }
            if(!Char.IsDigit(s[i]) && s[i] != ' ' || i == s.Length - 1){
                if(opr == '+')
                    st.Push(num);
                if(opr == '-')
                    st.Push(-num);
                if(opr == '*')
                    st.Push(st.Pop() * num);
                if(opr == '/')
                    st.Push(st.Pop() / num);
                num = 0;
                opr = s[i];
            }
        }
        int result = 0;
        while(st.Count > 0)
            result += st.Pop();
        return result;
    }
}