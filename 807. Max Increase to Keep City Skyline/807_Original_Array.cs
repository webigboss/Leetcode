public class Solution {
    public int MaxIncreaseKeepingSkyline(int[][] grid) {
        var l = grid.Length;
        var hor = new int[l];
        var ver = new int[l];
        for(var i = 0; i < l; ++i)
            for(var j = 0; j < l; ++j)
                ver[i] = Math.Max(ver[i], grid[i][j]);                
            
        for(var j = 0; j < l; ++j)
            for(var i = 0; i < l; ++i)
                hor[j] = Math.Max(hor[j], grid[i][j]);
        
        var ans = 0; 
        for(var i = 0; i < l; ++i)
            for(var j = 0; j < l; ++j)
                ans += Math.Min(ver[i], hor[j]) - grid[i][j];
        
        return ans;
    }
}