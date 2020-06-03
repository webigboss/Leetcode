public class Solution {
    public int[][] Transpose(int[][] A) {
        int r = A.Length, c = A[0].Length;
        var ans = new int[c][];
        for(var i = 0; i < c; ++i){
            ans[i] = new int[r];
            for(var j = 0; j < r; ++j){
                ans[i][j] = A[j][i];
            }
        }
        return ans;
    }
}