public class Solution {
    public int NumIslands(char[][] grid) {
        //BFS solution
        var count = 0;
        
        for(var y = 0; y < grid.Length; y++){
            for(var x = 0; x < grid[0].Length; x++){
                if(grid[y][x] == '1'){
                    BfsHelper(grid, x, y);
                    count++;
                }
            }
        }
        return count;
    }
    
    private void BfsHelper(char[][] grid, int x, int y){
        var q = new Queue<int[]>();
        q.Enqueue(new []{x, y});
        int[] indices;
        while(q.Count > 0){
            indices = q.Dequeue();
            x = indices[0];
            y = indices[1];
            if(grid[y][x] == '0')
                continue;
            grid[y][x] = '0';
            
            if(y > 0 && grid[y - 1][x] == '1')
                q.Enqueue(new []{x, y - 1});
            if(y < grid.Length - 1 && grid[y + 1][x] == '1')
                q.Enqueue(new []{x, y + 1});
            if(x > 0 && grid[y][x - 1] == '1')
                q.Enqueue(new []{x - 1, y});
            if(x < grid[0].Length - 1 && grid[y][x + 1] == '1')
                q.Enqueue(new []{x + 1, y});
        }
    }
}