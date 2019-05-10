public class Solution {
    public int MinPathSum(int[][] grid) {
        if(grid == null || grid.Length == 0 || grid[0] == null || grid[0].Length == 0)
            return 0;
        
        var dp = new int[grid[0].Length + 1, grid.Length + 1];
                //base cases
        dp[1, 1] = grid[0][0];
        for(var i = 1; i < dp.GetLength(0); i++){
            dp[i, 0] = int.MaxValue;
        }
        for(var j = 1; j < dp.GetLength(1); j++){
            dp[0, j] = int.MaxValue;
        }
        
        for(var x = 1; x < dp.GetLength(0); x++){
            for(var y = 1; y < dp.GetLength(1); y++){
                if(y == 1 && x == 1)
                    continue;
                dp[x, y] = grid[y - 1][x - 1] + Math.Min(dp[x - 1, y], dp[x, y- 1]);
            }
        }
        
        return dp[grid[0].Length, grid.Length];
    }
}