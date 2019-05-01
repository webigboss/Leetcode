public class Solution {
    public int[][] GenerateMatrix(int n) {
        var matrix = new int[n][];
        for(var j = 0; j < n; j++)
            matrix[j] = new int[n];
        var xmin = 0;
        var ymin = 0;
        var xmax = n - 1;
        var ymax = n - 1;
        var direction = Direction.LeftToRight;
        var i = 1;
        while(xmin <= xmax && ymin <= ymax){         
            switch (direction){
                case Direction.LeftToRight:
                    for(var x = xmin; x <= xmax; x++){
                        matrix[ymin][x] = i++;
                    }
                    ymin++;
                    direction = Direction.TopDown;
                    break;
                case Direction.TopDown:
                    for(var y = ymin; y <= ymax; y++){
                        matrix[y][xmax] = i++;
                    }
                    xmax--;
                    direction = Direction.RightToLeft;
                    break;
                case Direction.RightToLeft:
                    for(var x = xmax; x >= xmin; x--){
                        matrix[ymax][x] = i++;
                    }
                    ymax--;
                    direction = Direction.BottomUp;
                    break;
                case Direction.BottomUp:
                    for(var y = ymax; y >= ymin; y--){
                        matrix[y][xmin] = i++;
                    }
                    xmin++;
                    direction = Direction.LeftToRight;
                    break;
                default:
                    break;
            }
        }
        return matrix;
    }
    
    public enum Direction{
        LeftToRight,
        TopDown,
        RightToLeft,
        BottomUp
    } 
}