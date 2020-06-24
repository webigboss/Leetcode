public class Solution {
    public int SurfaceArea(int[][] grid) {
        int ans = 0, r = grid.Length, c = grid[0].Length, maxHeight = 0;
        //up & down 
        for(var i = 0; i < r; ++i) {
            for(var j = 0; j < c; ++j) {
                if(grid[i][j] != 0) {
                    ans += 2;
                    maxHeight = Math.Max(maxHeight, grid[i][j]);
                }
            }
        }
        
        var neighbours = new []{
            new []{0, 1},
            new []{0, -1},
            new []{1, 0},
            new []{-1, 0},
        };
        
        for(var h = 0; h < maxHeight; ++h){
            for(var i = 0; i < r; ++i){
                for(var j = 0; j < c; ++j){
                    if(grid[i][j] <= h) continue;
                    foreach(var n in neighbours){
                        var nr = i + n[0];
                        var nc = j + n[1];
                        if(nr < 0 || nr >= r || nc < 0 || nc >= c) {
                            ans++;
                            continue;
                        }
                        //Console.WriteLine($"nr:{nr}; nc:{nc}");
                        if(grid[nr][nc] <= h) ans++;
                    }
                }
            }
        }

        return ans;
    }
}