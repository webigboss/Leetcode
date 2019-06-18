public class Solution {
    public int Calculate(string s) {
        var st = new Stack<int>();
        int num = 0;
        int sign = 1;
        int result = 0;
        for(var i = 0; i < s.Length; i++){
            if(Char.IsDigit(s[i]))
                num = num * 10 + (s[i] - '0');
            else if(s[i] == '+' || s[i] == '-'){
                result += sign * num;
                sign = s[i] == '+' ? 1 : -1;
                num = 0;
            }
            else if(s[i] == '('){
                st.Push(result);
                st.Push(sign);
                sign = 1; 
                result = 0;
            }
            else if(s[i] == ')'){
                result += sign * num;
                sign = st.Pop();
                result = st.Pop() + sign * result;
                num = 0;
            }
        }
        if(num != 0)
            result += sign * num;
        return result;
    }
}