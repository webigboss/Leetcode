public class Solution {
    public bool IsValidSerialization(string preorder) {
        var strs = preorder.Split(',');
        var st = new Stack<string>();
        for(var i = 0; i < strs.Length; i++){
            if(strs[i] == "#"){
                while(st.Count > 0 && st.Peek() == "#"){
                    st.Pop();
                    st.Pop();
                }
                if(st.Count == 0){
                    if(i == strs.Length - 1) return true;
                    return false;
                }
                st.Push(strs[i]);
            }
            else
                st.Push(strs[i]);
        }
        
        return st.Count == 0;
    }
}