public class Solution {
    public bool SearchMatrix(int[,] matrix, int target) {
        if(matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
            return false;
        
        int xend = matrix.GetLength(0) - 1;
        int ystart = 0;
        
        while(xend >= 0 && ystart <= matrix.GetLength(1) - 1){
            if(matrix[xend, ystart] > target){
                xend--;
            }
            else if(matrix[xend, ystart] < target){
                ystart++;
            }
            else{    //matrix[xend, ystart] == target
                return true;
            }
        }
        return false;
    }
    
}