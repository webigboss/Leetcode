public class Solution {
    public int FindLength(int[] A, int[] B) {
        //dp bottom up 
        var dp = new int[A.Length+1, B.Length+1];
        var ans = 0;
        for(var i = 1; i <= A.Length; ++i){
            for(var j = 1; j <= B.Length; ++j){
                dp[i,j] = 0;
                if(A[i-1] == B[j-1]){
                    dp[i,j] = Math.Max(dp[i,j], dp[i-1, j-1]+1);
                }
                ans = Math.Max(ans, dp[i,j]);
            }
        }
        return ans;
    }
}