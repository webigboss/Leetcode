public class Solution {
    public int OrangesRotting(int[][] grid) {
        //BFS with queue approach
        var neighbours = new []{
            new[] {0, 1},
            new[] {0, -1},
            new[] {1, 0},
            new[] {-1, 0},
        };
        var result = 0;
        var cur = 0;
        var ly = grid.Length;
        var lx = grid[0].Length;
        var q = new Queue<int[]>();
        for(var y = 0; y < ly; ++y){
            for(var x = 0; x < lx; ++x){
                if(grid[y][x] == 0 || grid[y][x] == 1) continue;
                q.Enqueue(new []{x, y, 0}); //the 3rd number is to record the minutes
            }
        }
        while(q.Count > 0){
            var item = q.Dequeue();
            var curx = item[0];
            var cury = item[1];
            var curm = item[2];
            result = Math.Max(result, curm);
            foreach(var n in neighbours){
                if(curx + n[0] >= 0 && curx + n[0] < lx && cury + n[1] >= 0 && cury + n[1] < ly
                  && grid[cury + n[1]][curx + n[0]] == 1){
                    grid[cury + n[1]][curx + n[0]] = 2;
                    q.Enqueue(new []{curx + n[0], cury + n[1], curm + 1});
                }
            }
        }
        
        for(var y = 0; y< ly; ++y){
            for(var x = 0; x < lx; ++x){
                if(grid[y][x] == 1) return -1;
            }
        }
        return result;
    }
}