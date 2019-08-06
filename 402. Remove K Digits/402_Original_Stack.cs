public class Solution {
    public string RemoveKdigits(string num, int k) {
        // 54236732 k = 3
        // 26732
        // 23732
        // 23632
        // 23672
        // 23673
        // use a stack, iterate through the string, when cur number is less than top of the stack, pop and push cur number, k--, till k =0;
        if(num.Length == k) return "0";
        var remains = k;
        var st = new Stack<char>();
        for(var i = 0; i < num.Length; i++){
            if(st.Count > 0 && num[i] < st.Peek()){
                while(st.Count > 0 && num[i] < st.Peek() && remains > 0){
                    st.Pop();
                    remains--;
                }
            }
            st.Push(num[i]);
        }
        var sb = new StringBuilder();
        var numList = new List<char>();
        var meetNonZero = false;
        while(st.Count > 0)
            numList.Add(st.Pop());
        numList.Reverse();
        foreach(var c in numList){
            if(c == '0' && !meetNonZero) continue;
            else{
                meetNonZero = true;
                if(sb.Length < num.Length - k)
                    sb.Append(c);
            }
        }
        if(sb.Length == 0) return "0";
        return sb.ToString();
    }
}