public class Solution {
    public bool IsMonotonic(int[] A) {
        int n = A.Length;
        if(n == 1) return true;
        //monitonic ascending
        var isMonoAsc = true;
        for(var i = 1; i < n; ++i){
            if(A[i] < A[i-1]){ 
                isMonoAsc = false;
                break;
            }
        }
        if(isMonoAsc) return true;

        var isMonoDesc = true;
        for(var i = n-2; i >= 0; --i){
            if(A[i] < A[i+1]){
                isMonoDesc = false;
                break;
            }
        }
        return isMonoDesc;
    }
}