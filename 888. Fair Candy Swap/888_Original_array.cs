public class Solution {
    public int[] FairCandySwap(int[] A, int[] B) {
        int sumA = 0, sumB = 0;
        var ans = new int[2];
        foreach(var n in A)
            sumA += n;
        foreach(var n in B)
            sumB += n;
        
        for(var i = 0; i < A.Length; ++i){
            for(var j = 0; j < B.Length; ++j){
                if(sumA > sumB && 2*(A[i]-B[j]) == sumA-sumB
                  || sumB > sumA && 2*(B[j]-A[i]) == sumB-sumA){
                    ans[0] = A[i];
                    ans[1] = B[j];
                    return ans;
                }
            }
        }
        return ans;
    }
}