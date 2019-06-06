public class Solution {
    public int MaximalSquare(char[][] matrix) {
        //DP Solution
        if(matrix.Length == 0 || matrix[0].Length == 0)
            return 0;
        var dp = new int[matrix[0].Length, matrix.Length];
        var maxSqrLength = 0;
        for(var y = 0; y < matrix.Length; y++){
            for(var x = 0; x < matrix[0].Length; x++){
                if(matrix[y][x] == '0')
                    continue;
                if(x == 0 || y == 0){
                    dp[x, y] = 1;
                    maxSqrLength = Math.Max(dp[x, y], maxSqrLength);
                    continue;
                }
                dp[x, y] = Math.Min(Math.Min(dp[x - 1, y], dp[x, y - 1]), dp[x - 1, y - 1]) + 1;
                maxSqrLength = Math.Max(dp[x, y], maxSqrLength);
            }
        }
        return maxSqrLength * maxSqrLength;
    }
}