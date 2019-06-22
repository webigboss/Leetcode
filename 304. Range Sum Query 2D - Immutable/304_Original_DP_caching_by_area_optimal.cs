public class NumMatrix {

    private int[,] _areaSum;
    public NumMatrix(int[][] matrix) {
        if(matrix.Length > 0 && matrix[0].Length > 0){
            _areaSum = new int[matrix[0].Length + 1, matrix.Length + 1];
            for(var r = 0; r < matrix.Length; r++){
                var tempsum = 0;
                for(var c = 0; c < matrix[0].Length; c++){
                    tempsum += matrix[r][c];
                    _areaSum[c + 1, r + 1] = tempsum + _areaSum[c + 1, r];
                }
            }
        }
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        if(_areaSum == null)
            return 0;
        return _areaSum[col2 + 1, row2 + 1] - _areaSum[col2 + 1, row1] - _areaSum[col1, row2 + 1] + _areaSum[col1, row1];
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */