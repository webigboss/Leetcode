public class Solution {
    public int LenLongestFibSubseq(int[] A) {
        //offical sol 1: brute force with set
        int n = A.Length;
        var hs = new HashSet<int>();
        foreach(var a in A)
            hs.Add(a);
        
        var ans = 0;
        for(var i = 0; i < n; ++i){
            for(var j = i+1; j < n; ++j){
                if(!hs.Contains(A[i]+A[j])) continue;
                int x = A[j], y = A[i]+A[j], cur = 2;
                while(hs.Contains(y)){
                    var temp = y;
                    y = x + y;
                    x = temp;
                    cur++;
                }
                ans = Math.Max(ans, cur);
            }
        }
        return ans;
    }
}