public class Solution {
    public bool BackspaceCompare(string S, string T) {
        var st = new Stack<char>();
        var st2 = new Stack<char>();
        for(var i = 0; i < S.Length; ++i){
            if(S[i] == '#' && st.Count > 0) st.Pop();
            if(S[i] != '#') st.Push(S[i]);
        }
        for(var i = 0; i < T.Length; ++i){
            if(T[i] == '#' && st2.Count > 0) st2.Pop();
            if(T[i] != '#') st2.Push(T[i]);
        }
        
        if(st.Count != st2.Count) return false;
        
        while(st.Count > 0)
            if(st.Pop() != st2.Pop()) return false;
        return true;
    }
}