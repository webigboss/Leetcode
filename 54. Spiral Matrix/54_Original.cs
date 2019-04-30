public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        var result = new List<int>();
        if(matrix.Length == 0 || matrix[0].Length == 0)
            return result;
        var xmin = 0;
        var ymin = 0;
        var xmax = matrix[0].Length - 1;
        var ymax = matrix.Length - 1;
        var direction = Direction.LeftToRight;
        
        while(xmin <= xmax && ymin <= ymax){         
            switch (direction){
                case Direction.LeftToRight:
                    for(var x = xmin; x <= xmax; x++){
                        result.Add(matrix[ymin][x]);
                    }
                    ymin++;
                    direction = Direction.TopDown;
                    break;
                case Direction.TopDown:
                    for(var y = ymin; y <= ymax; y++){
                        result.Add(matrix[y][xmax]);
                    }
                    xmax--;
                    direction = Direction.RightToLeft;
                    break;
                case Direction.RightToLeft:
                    for(var x = xmax; x >= xmin; x--){
                        result.Add(matrix[ymax][x]);
                    }
                    ymax--;
                    direction = Direction.BottomUp;
                    break;
                case Direction.BottomUp:
                    for(var y = ymax; y >= ymin; y--){
                        result.Add(matrix[y][xmin]);
                    }
                    xmin++;
                    direction = Direction.LeftToRight;
                    break;
                default:
                    break;
            }
        }
        return result;
    }
    
    public enum Direction{
        LeftToRight,
        TopDown,
        RightToLeft,
        BottomUp
    } 
}