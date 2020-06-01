public class Solution {
    public int[] LoudAndRich(int[][] richer, int[] quiet) {
        var n = quiet.Length;
        Console.WriteLine(n);
        var ans = new int[n];
        Array.Fill(ans, -1);
        var dict = new Dictionary<int, List<int>>();
        for(var i = 0; i < richer.Length; ++i){
            if(!dict.ContainsKey(richer[i][1]))
               dict[richer[i][1]] = new List<int>();
            dict[richer[i][1]].Add(richer[i][0]);
        }
        var st = new Stack<int>();
        for(var i = 0; i < n; ++i){
            st.Clear();
            st.Push(i);
            var curval = n;
            var icur = -1;
            while(st.Count > 0){
                var k = st.Pop();
                if(curval >= quiet[k]){
                    curval = quiet[k];
                    icur = k;
                }
                if(ans[k] > -1){
                    if(curval >= quiet[ans[k]]){
                        curval = quiet[ans[k]];
                        icur = ans[k];
                    }
                    continue;
                }
                if(!dict.ContainsKey(k)) continue;
                foreach(var j in dict[k])
                    st.Push(j);
            }
            ans[i] = icur;
        }
        return ans;
    }
}