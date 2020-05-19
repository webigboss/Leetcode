public class Solution {
    public bool SplitArraySameAverage(int[] A) {
        int sA = 0, lA = A.Length;
        if(lA == 1) return false;
        foreach(var a in A)
            sA+=a; 
        var flag = true;
        for(var lB = 1; lB <= 15 && flag; ++lB){
            if(sA*lB%lA != 0) continue;
            else flag = false;
        }
        if(flag) return false;
        
        var sums = new HashSet<int>[lA/2 +1];
        for(var i = 0; i < sums.Length; ++i)
            sums[i] = new HashSet<int>();
        sums[0].Add(0);
        foreach(var num in A){
            for(var i = lA/2; i >=1; --i){
                foreach(var t in sums[i-1]){
                    sums[i].Add(t + num);
                }
            }
        }
        for(var lB = 1; lB <= lA/2; ++lB){
            if(sA*lB%lA == 0 
              && sums[lB].Contains(sA*lB/lA)) return true;
        }
        return false;
    }
}