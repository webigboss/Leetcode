public class Solution {
    public int MatrixScore(int[][] A) {
        //iterate rows, turn the first column to all 1 first
        //then iterate on columns, toggle if there are more 0s than 1s
        int r = A.Length, c = A[0].Length, ans = 0;
        for(var j = 0; j < c; ++j){
            var cnt = 0;
            for(var i = 0; i < r; ++i){
                cnt += A[i][j] ^ A[i][0]; //don't update A[i][j] because it may update A[i][0] if it's initial value is 1;
            }
            ans += Math.Max(cnt, r-cnt) * (1 << c-j-1);
        }
        return ans;
    }    
}