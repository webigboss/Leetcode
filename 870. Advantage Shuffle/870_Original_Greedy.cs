public class Solution {
    public int[] AdvantageCount(int[] A, int[] B) {
        var pairB = new int[B.Length][];
        for(var i = 0; i < B.Length; ++i){
            pairB[i] = new int[2];
            pairB[i][0] = B[i];
            pairB[i][1] = i;
        }
        var used = new bool[A.Length];
        Array.Sort(A);
        Array.Sort(pairB, (a,b)=>a[0]-b[0]);
        var ans = new int[A.Length];
        var j = 0;
        
        for(var i = 0; i < A.Length; ++i){
            if(A[i] > pairB[j][0]){
                ans[pairB[j][1]] = A[i];
                used[i] = true;
                j++;
            }
        }
        
        for(var i = 0; i < A.Length; ++i){
            if(used[i]) continue;
            ans[pairB[j][1]] = A[i];
            used[i] = true;
            j++;
        }
        return ans;
    }
}