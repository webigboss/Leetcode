public class Solution {
    public string SimplifyPath(string path) {
        var st = new Stack();
        var a = path.Split('/');
        var result = "";
        for(var i = 1; i < a.Length; i++){
            switch (a[i]){
                case ".":
                    break;
                case "..":
                    if(st.Count > 0)
                        st.Pop();
                    break;
                case null:
                    break;
                case "":
                    break;
                default:
                    st.Push(a[i]);
                    break;
            }
        }
        
        while(st.Count != 0){
            result = "/" + (string)st.Pop() + result;
        }
        
        return result.Length == 0 ? "/" : result;
    }
}