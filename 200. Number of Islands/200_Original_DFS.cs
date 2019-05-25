public class Solution {
    public int NumIslands(char[][] grid) {
        //DFS solution
        var count = 0;
        
        for(var y = 0; y < grid.Length; y++){
            for(var x = 0; x < grid[0].Length; x++){
                if(grid[y][x] == '1'){
                    DfsHelper(grid, x, y);
                    count++;
                }
            }
        }
        return count;
    }
    
    private void DfsHelper(char[][] grid, int x, int y){
        grid[y][x] = '0';
        if(y > 0 && grid[y - 1][x] == '1')
            DfsHelper(grid, x, y - 1);
        if(y < grid.Length - 1 && grid[y + 1][x] == '1')
            DfsHelper(grid, x, y + 1);
        if(x > 0 && grid[y][x - 1] == '1')
            DfsHelper(grid, x - 1, y);
        if(x < grid[0].Length - 1 && grid[y][x + 1] == '1')
            DfsHelper(grid, x + 1, y);
    }
}