public class Solution {
    public int NumIslands(char[][] grid) {
        //BFS with queue approach, revisited 2020/03/08
        if(grid.Length == 0 || grid[0].Length == 0) return 0;
        var q = new Queue<int[]>();
        var result = 0;
        var ly = grid.Length;
        var lx = grid[0].Length;
        int curx, cury;
        var neighbours = new []{
            new []{1, 0},
            new []{-1, 0},
            new []{0, 1},
            new []{0, -1}
        };
        for(var y = 0; y < ly; ++y){
            for(var x = 0; x < lx; ++x){
                if(grid[y][x] == '0') continue;
                q.Enqueue(new []{x, y});
                while(q.Count > 0){
                    var item = q.Dequeue();
                    curx = item[0];
                    cury = item[1];
                    //!! checking if current element is visited, this is important for BFS to optimize by avoid adding same element into queue;
                    if(grid[cury][curx] == '0') continue;
                    grid[cury][curx] = '0';
                    foreach(var n in neighbours){
                        if(curx + n[0] >= 0 && curx + n[0] < lx && cury + n[1] >= 0 && cury + n[1] < ly){
                            if(grid[cury + n[1]][curx + n[0]] == '1')
                                q.Enqueue(new []{curx + n[0], cury + n[1]});
                        }
                    }
                }
                result++;
            }
        }
        return result;
    }
}