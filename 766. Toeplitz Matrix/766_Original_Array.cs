public class Solution {
    public bool IsToeplitzMatrix(int[][] matrix) {
        var lr = matrix.Length;
        var lc = matrix[0].Length;
        for(var c = 0; c < lc; ++c){
            int curc, curr;
            curc = c; 
            curr = 0;
            var val = matrix[curr][curc];
            while(curc < lc && curr < lr){
                if(matrix[curr++][curc++] != val)
                    return false;
            }
        }
        
        for(var r = 1; r < lr; ++r){
            int curc, curr;
            curr = r;
            curc = 0;
            var val = matrix[curr][curc];
            while(curc < lc && curr < lr){
                if(matrix[curr++][curc++] != val)
                    return false;
            }
        }
        return true;
    }
}