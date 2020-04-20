public class Solution {
    public int MaxCount(int m, int n, int[][] ops) {
        var minr = m;
        var minc = n;

        for(var i = 0; i < ops.Length; ++i){
            var r = ops[i][0];
            var c = ops[i][1];
            if(r == 0 || c == 0) continue;

            minr = Math.Min(minr, r);
            minc = Math.Min(minc, c);
        }
        
        return minr * minc;
    }
}