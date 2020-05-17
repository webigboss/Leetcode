public class Solution {
    public bool RotateString(string A, string B) {
        //if(A == null && B != null || A != null && B== null) return false;
        if(A == B) return true;
        if(A.Length != B.Length) return false;
        for(var i = 0; i < A.Length; ++i){
            var j = i;
            var isValid = true;
            for(var k = 0; k < B.Length; k++){
                if(A[j] != B[k]){
                    isValid = false;
                    break;
                }
                j = (j+1) % A.Length;
            }
            if(isValid) return true;
        }
        return false;
    }
}