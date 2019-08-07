public class Solution {
    public int NumIslands(char[][] grid) {
        //BFS iterative approach with queue
        var q = new Queue<int[]>();
        var count = 0;
        for(var y = 0; y < grid.Length; y++){
            for(var x = 0; x < grid[0].Length; x++){
                if(grid[y][x] == '1'){  
                    q.Enqueue(new []{x, y});
                    while(q.Count > 0){
                        var elem = q.Dequeue();
                        var x1 = elem[0];
                        var y1 = elem[1];
                        //!! checking if current element is visited, this is important for BFS to optimize by avoid adding same element into queue;
                        if(grid[y1][x1] == '0') continue;
                        grid[y1][x1] = '0';
                        if(y1 > 0 && grid[y1 - 1][x1] == '1')
                            q.Enqueue(new []{x1, y1 - 1});
                        if(y1 < grid.Length - 1 && grid[y1 + 1][x1] == '1')
                            q.Enqueue(new []{x1, y1 + 1});
                        if(x1 > 0 && grid[y1][x1 - 1] == '1')
                            q.Enqueue(new []{x1 - 1, y1});
                        if(x1 < grid[0].Length - 1 && grid[y1][x1 + 1] == '1')
                            q.Enqueue(new []{x1 + 1, y1});
                    }
                    count++;
                }
            }
        }
        return count;
    }
}