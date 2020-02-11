public class Solution {
    public int FourSumCount(int[] A, int[] B, int[] C, int[] D) {
        //1. sort the 4 arrays
        Array.Sort(A);
        Array.Sort(B);
        Array.Sort(C);
        Array.Sort(D);
        //2. 
        var sumCount = 0;
        for(var i = 0; i < A.Length; i++){
            sumCount += ThreeSumCount(0 - A[i], B, C, D);
        }
        return sumCount;
    }
    
    private int ThreeSumCount(int target, int[] B, int[] C, int[] D){
        var sumCount = 0;
        for(var i = 0; i < B.Length; i++){
            sumCount += TwoSumCount(target - B[i], C, D);
        }
        return sumCount;
    }
    
    private int TwoSumCount(int target, int[] C, int[] D){
        var sumCount = 0;
        for(var i = 0; i < C.Length; i++){
            sumCount += FindTargetCount(target - C[i], D);
        }
        return sumCount;
    }
    
    private int FindTargetCount(int target, int[] D){
        var targetCount = 0;
        var index = Array.BinarySearch(D, target);
        if(index >= 0) {
            targetCount++;
            //to the right
            var cur = index + 1;
            while(cur < D.Length && D[cur] == D[index]){
                targetCount++;
                cur++;
            }
            //to the left
            cur = index - 1;
            while(cur >= 0 && D[cur] == D[index]){
                targetCount++;
                cur--;
            }
        }
        return targetCount;
    } 
}