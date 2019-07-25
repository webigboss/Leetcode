public class Solution {
    public string DecodeString(string s) {
        var st = new Stack<string>();
        var sbNum = new StringBuilder();
        for(var i = 0; i < s.Length; i++){
            if(Char.IsDigit(s[i])){
                sbNum.Append(s[i]);
                continue;
            }

            if(s[i] == ']'){
                var temp = "";
                var temp2 = "";
                while(st.Count > 0 && st.Peek() != "["){
                    temp = st.Pop() + temp;
                }
                //Pop '[' out
                st.Pop();
                var k = int.Parse(st.Pop());
                while(k-- > 0)
                    temp2 = temp2 + temp;
                st.Push(temp2);
            }
            else{
                if(s[i] == '['){
                    st.Push(sbNum.ToString());
                    sbNum.Clear();
                }
                st.Push(s[i].ToString());
            }
        }
        var result = "";
        while(st.Count > 0){
            result = st.Pop() + result;
        }
        return result;
    }
}