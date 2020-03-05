public class Solution {
    public int[] FindDiagonalOrder(int[][] matrix) {
        if(matrix.Length == 0 || matrix[0].Length == 0) return new int[0];
        var isUpRight = true;
        var ly = matrix.Length;
        var lx = matrix[0].Length;
        var result = new int[lx*ly];
        var x = 0;
        var y = 0;
        var i = 0;
        while(true){
            result[i++] = matrix[y][x];
            if(x == lx - 1 && y == ly - 1)
                break;
            if(isUpRight){
                if(x == lx - 1){ // this must be before y==0's check, because when it reaches the top right corner where both x==lx - 1 and y == 0, it the next point should be y++
                    y++;
                    isUpRight = !isUpRight;
                }
                else if(y == 0){
                    x++;
                    isUpRight = !isUpRight;
                }
                else{
                    x++;
                    y--;
                }
            }
            else{
                if(y == ly - 1){
                    x++;
                    isUpRight = !isUpRight;
                }
                else if(x == 0){
                    y++;
                    isUpRight = !isUpRight;
                }
                else{
                    x--;
                    y++;
                }
            }
        }
        return result;
    }
}