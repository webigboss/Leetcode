public class Solution {
    public int ScoreOfParentheses(string S) {
        var st = new Stack<int>();
        st.Push(0); // add an additional item into the stack to collect the answer, also make sure we will never run into a case of popping an empty stack;

        foreach(var c in S){
            if(c == ')') {
                var cur = st.Pop();
                var top = st.Pop();
                if(cur == 0)
                    top += 1;
                else
                    top += cur*2;
                st.Push(top);
            }
            else
                st.Push(0);    
        }
        
        return st.Peek();
    }
}