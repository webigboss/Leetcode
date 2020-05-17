public class Solution {
    public int NumSubarrayBoundedMax(int[] A, int L, int R) {
        var ans = 0;
        var cnt = 0;
        var prev = 0;
        var found = false;
        for(var i = 0; i < A.Length; ++i){
            cnt++;
            if(A[i] > R){
                cnt = 0;
                prev = 0;
            }
            else if(A[i] >= L){
                ans += cnt;
                prev = cnt;
            }
            else{ // A[i] < L
                ans += prev;
            }
        }
        return ans;
    }
}