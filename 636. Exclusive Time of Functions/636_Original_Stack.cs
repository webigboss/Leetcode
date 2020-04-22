public class Solution {
    public int[] ExclusiveTime(int n, IList<string> logs) {
        var st = new Stack<int[]>();
        var ans = new int[n];
        
        for(var i = 0; i < logs.Count; ++i){
            var a = logs[i].Split(':');
            var f = int.Parse(a[0]);
            var t = int.Parse(a[2]);
            if(a[1] == "start"){
                st.Push(new []{f, t});
            }
            else{
                var item = st.Pop();
                var time = t - item[1] + 1;
                ans[f] += time;
                if(st.Count > 0){
                    var peek = st.Peek();
                    ans[peek[0]] -= time;
                }
            }
        }
        return ans;
    }
}