public class Solution {
    public int[] DailyTemperatures(int[] T) {
        var st = new Stack<int[]>();
        var ans = new int[T.Length];
        for(var i = T.Length-1; i >= 0; --i){            
            while(st.Count > 0){
                if(T[i] >= st.Peek()[0])
                    st.Pop();
                else{
                    ans[i] = st.Peek()[1] - i;
                    st.Push(new []{T[i], i});
                    //Console.WriteLine($"st.Push->[{T[i]},{i}]");
                    break;
                }
            }
            
            if(st.Count == 0){
                ans[i] = 0;
                st.Push(new []{T[i], i});
            }
        }
        return ans;
    }
}