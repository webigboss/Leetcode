public class Solution {
    public void Rotate(int[][] matrix) {
        //matrix[y][x]
        //step 1: flip y axis up-side-down
        var temp = new int[matrix.Length - 1];
        for(var i = 0; i < matrix.Length / 2; i++){
            temp = matrix[i];
            matrix[i] = matrix[matrix.Length - 1 - i];
            matrix[matrix.Length - 1 - i] = temp;
        }
        
        //step 2: swap elements from upper-left to lower-right diagonal
        var j = 0;
        for(var x = 1; x < matrix.Length; x++){
            for(var y = 0; y < x; y++){
                j = matrix[y][x];
                matrix[y][x] = matrix[x][y];
                matrix[x][y] = j;
            }
        }
    }
}