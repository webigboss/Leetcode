public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        var dp = new int[obstacleGrid[0].Length + 1, obstacleGrid.Length + 1];
        
        for(var x = 1; x <= dp.GetLength(0) - 1; x++){
            for(var y = 1; y <= dp.GetLength(1) - 1; y++){
                if(obstacleGrid[y - 1][x - 1] == 1){
                    dp[x, y] = 0;
                    continue;
                }
                //base case
                if(y == 1 && x == 1){
                    dp[x, y] = 1;
                    continue;
                }
                
                dp[x, y] = dp[x - 1, y] + dp[x, y - 1]; 
            }
        }
        return dp[dp.GetLength(0) - 1, dp.GetLength(1) - 1]; 
    }
}