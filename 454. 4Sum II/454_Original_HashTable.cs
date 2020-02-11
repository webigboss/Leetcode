public class Solution {
    public int FourSumCount(int[] A, int[] B, int[] C, int[] D) {
        var dict = new Dictionary<int, int>();
        
        for(var i = 0; i < A.Length; i++){
            for(var j = 0; j < B.Length; j++){
                if(!dict.ContainsKey(A[i] + B[j]))
                    dict[A[i] + B[j]] = 1;
                else
                    dict[A[i] + B[j]]++;
            }
        }
        
        var result = 0;
        for(var i = 0; i < C.Length; i++){
            for(var j = 0; j < D.Length; j++){
                if(dict.ContainsKey(-1 * (C[i] + D[j]))){
                    result += dict[-1 * (C[i] + D[j])]; 
                }
            }
        }
        return result;
    }
}