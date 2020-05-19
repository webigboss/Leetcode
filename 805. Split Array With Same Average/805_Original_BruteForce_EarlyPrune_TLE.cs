public class Solution {
    public bool SplitArraySameAverage(int[] A) {
        int sA = 0, lA = A.Length;
        if(lA == 1) return false;
        foreach(var a in A)
            sA+=a; 
        for(var lB = 1; lB <= 15; ++lB){
            if(sA*lB%lA != 0) continue;
            
            var sB = sA*lB/lA;
            Console.WriteLine($"Valid LenB:{lB}, sumB:{sB}");
            //if(lB != 8) continue;
            if(FindByLength(A, lB, sB, 0, 0, 0)) return true;
        }
        return false;
    }
    
    bool FindByLength(int[] A, int lB, int sB, int curSum, int curCnt, int index){
        Console.WriteLine($"lB:{lB}, sB:{sB}, curSum:{curSum}, curCnt:{curCnt}, index:{index}");
        if(index == A.Length || curSum > sB) return false;
        if(curCnt == lB){
            if(sB == curSum) return true;
            return false;
        }
        
        if(FindByLength(A, lB, sB, curSum+A[index], curCnt+1, index+1)) return true;
        if(FindByLength(A, lB, sB, curSum, curCnt, index+1)) return true;
        return false;
    }
}