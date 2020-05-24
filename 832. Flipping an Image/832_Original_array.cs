public class Solution {
    public int[][] FlipAndInvertImage(int[][] A) {
        int lr = A.Length, lc = A[0].Length;
        var ret = new int[lr][];
        for(var i = 0; i < lr; ++i)
            ret[i] = new int[lc];
        
        for(var i = 0; i < lr; ++i){
            for(var j = lc - 1; j >= 0; --j){
                ret[i][lc-1-j] = 1 - A[i][j];
            }
        }
        return ret;
    }
}