public class Solution {
    public int EvalRPN(string[] tokens) {
        // solution 1: from left to right
        var st = new Stack();
        int iout;
        int right, left;
        for(var i = 0; i < tokens.Length; i++){
            if(int.TryParse(tokens[i], out iout))
                st.Push(int.Parse(tokens[i]));
            else{ // operator
                right = (int)st.Pop();
                left = (int)st.Pop();
                switch(tokens[i]){
                    case "+":
                        st.Push(right + left);
                        break;
                    case "-":
                        st.Push(left - right);
                        break;
                    case "*":
                        st.Push(left * right);
                        break;
                    case "/":
                        st.Push((int)(left / right));
                        break;
                    default:
                        break;
                }
            }
        }
        return (int)st.Pop();
    }
}