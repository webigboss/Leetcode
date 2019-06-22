public class NumMatrix {

    private int[,] _sumMatrix;
    public NumMatrix(int[][] matrix) {
        if(matrix.Length > 0 && matrix[0].Length > 0){
        _sumMatrix = new int[matrix[0].Length + 1, matrix.Length];
            for(var r = 0; r < matrix.Length; r++){
                for(var c = 0; c < matrix[0].Length; c++){
                    _sumMatrix[c + 1, r] = _sumMatrix[c, r] + matrix[r][c];
                }
            }
        }
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        var sum = 0;
        if(_sumMatrix != null){
            for(var r = row1; r <= row2; r++){
                sum += _sumMatrix[col2 + 1, r] - _sumMatrix[col1, r];
            }
        }
        return sum;
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */