public class Solution {
    public int CalPoints(string[] ops) {
        var st = new Stack<int>();

        foreach(var op in ops){
            if(int.TryParse(op, out var num)){
                st.Push(num);
            }
            else if(op == "D"){
                if(st.Count > 0){
                    st.Push(st.Peek() * 2);
                }
            }
            else if(op == "+"){
                var k = 2;
                var sum = 0;
                var temp = new int[2];
                while(st.Count > 0 && k-- > 0){
                    var n = st.Pop();
                    temp[k] = n;
                    sum += n;
                }
                st.Push(temp[0]);
                st.Push(temp[1]);
                st.Push(sum);
            }
            else if(op == "C"){
                if(st.Count > 0)
                    st.Pop();
            }
        }
        
        var ans = 0;
        while(st.Count > 0){
            ans += st.Pop();
        }
        return ans;
    }
}