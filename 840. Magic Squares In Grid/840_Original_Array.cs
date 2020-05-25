public class Solution {
    public int NumMagicSquaresInside(int[][] grid) {
        int lr = grid.Length, lc = grid[0].Length;
        var ans = 0;
        for(var i = 0; i <= lr - 3; ++i){
            for(var j = 0; j <= lc - 3; ++j){
                if(IsMagic(grid, i, j)) ans++;        
            }
        }
        return ans;
        
    }
    
    bool IsMagic(int[][] grid, int r, int c){
        // Console.WriteLine($"r:{r};c:{c}");
        var cnt = new int[9];
        int prev = 0;
        for(var i = r; i < r+3; ++i){
            int temp = 0;
            for(var j = c; j < c+3; ++j){
                // Console.WriteLine($"i:{i};j:{j}");
                if(grid[i][j] < 1 || grid[i][j] > 9 || cnt[grid[i][j]-1] > 0) return false;
                cnt[grid[i][j]-1]++;
                temp += grid[i][j]; 
            }
            if(prev != 0 && prev != temp) return false;
            prev = temp;
        }
        prev = 0;
        for(var j = c; j < c+3; ++j){
            int temp = 0;
            for(var i = r; i < r+3; ++i)
                temp+= grid[i][j];
            if(prev != 0 && prev != temp) return false;
            prev = temp;
        }
        
        return grid[r][c]+grid[r+1][c+1]+grid[r+2][c+2] 
            == grid[r][c+2]+grid[r+1][c+1]+grid[r+2][c]; 
        
    }
}