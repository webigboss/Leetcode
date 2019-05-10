public class Solution {
    public void SetZeroes(int[][] matrix) {
        bool zeroX = false;
        bool zeroY = false;
        for(var y = 0; y <= matrix.Length - 1; y++){
            for(var x = 0; x <= matrix[0].Length - 1; x++){
                if(matrix[y][x] == 0){
                    if(x == 0 && y == 0){
                        zeroX = true;
                        zeroY = true;
                    }
                    else if(x == 0 && y != 0){
                        zeroY = true;
                    }
                    else if (y == 0 && x != 0){
                        zeroX = true;
                    }
                    else{
                        matrix[0][x] = 0;
                        matrix[y][0] = 0;
                    }
                }
            }
        }
        
        for(var y = 1; y <= matrix.Length - 1; y++){
            if(matrix[y][0] == 0){
                for(var x = 1;  x <= matrix[0].Length - 1; x++)
                    matrix[y][x] = 0;
            }
        }
        
        for(var x = 1; x <= matrix[0].Length - 1; x++){
            if(matrix[0][x] == 0){
                for(var y = 1; y <= matrix.Length - 1; y++){
                    matrix[y][x] = 0;
                }
            }
        }
        
        if(zeroY){
            for(var y = 0; y <= matrix.Length - 1; y++)
                matrix[y][0] = 0;
        }
        if(zeroX){
            for(var x = 0; x <= matrix[0].Length - 1; x++)
                matrix[0][x] = 0;
        }
    }
}