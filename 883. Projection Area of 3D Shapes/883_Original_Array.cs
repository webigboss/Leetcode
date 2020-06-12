public class Solution {
    public int ProjectionArea(int[][] grid) {
        int ans = 0, cur = 0, zcnt = 0, r = grid.Length, c = grid[0].Length;
        for(var i = 0; i < r; ++i){
            cur = 0;
            for(var j = 0; j < c; ++j){
                if(grid[i][j] > 0) zcnt++;
                cur = Math.Max(cur, grid[i][j]);
            }
            ans += cur;
        }
        
        for(var j = 0; j < c; ++j){
            cur = 0;
            for(var i = 0; i < r; ++i){
                cur = Math.Max(cur, grid[i][j]);
            }
            ans += cur;
        }
        
        ans += zcnt;
        return ans;
    }
}