public class Solution {
    public int MaxRotateFunction(int[] A) {
        //brute force solution
        var n = A.Length;
        if(n == 0) return 0;
        var result = int.MinValue;
        
        for(var i = 0; i < n; i++){
            var tempResult = 0;
            for(var j = 0; j < n; j++){
                var index = i + j < n ? (i + j) : (i + j - n) ;
                tempResult += A[index] * j;
            }
            result = Math.Max(result, tempResult);
        }
        
        return result;
    }
}