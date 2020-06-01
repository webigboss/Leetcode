public class Solution {
    public bool BuddyStrings(string A, string B) {
        if(A.Length != B.Length) return false;
        int[] cntA = new int[26], cntB = new int[26];
        var hasDuplicates = false;
        var mismatch = 0;
        for(var i = 0; i < A.Length; ++i){
            cntA[A[i] - 'a']++;
            cntB[B[i] - 'a']++;
            if(A[i] != B[i])
                mismatch++;
        }
        
        for(var i = 0; i < 26; ++i){
            if(cntA[i] > 1 && !hasDuplicates) hasDuplicates = true;
            if(cntA[i] != cntB[i]) return false;
        }
        
        return mismatch == 2 || mismatch == 0 && hasDuplicates;
    }
}