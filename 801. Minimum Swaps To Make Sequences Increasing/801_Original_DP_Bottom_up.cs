public class Solution {
    //https://leetcode.com/problems/minimum-swaps-to-make-sequences-increasing/discuss/119835/Java-O(n)-DP-Solution
    public int MinSwap(int[] A, int[] B) {
        int swap = 1, fix = 0;
        for(var i = 1; i < A.Length; ++i){
            int tempSwap = swap, tempFix = fix;
            if(A[i] <= A[i-1] || B[i] <= B[i-1]){
                swap = tempFix+1;
                fix = tempSwap;
            }
            else if(A[i] <= B[i-1] || B[i] <= A[i-1]){
                swap = tempSwap+1;
                fix = tempFix;
            }
            else{ //A[i] > A[i-1] && B[i] > B[i-1] && A[i] > B[i-1] && B[i] > A[i-1]
                swap = Math.Min(tempSwap, tempFix) + 1;
                fix = Math.Min(tempSwap, tempFix);
            }
        }
        
        return Math.Min(swap, fix);
    }
}