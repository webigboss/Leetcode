public class Solution {
    public int IslandPerimeter(int[][] grid) {
        //bfs with queue
        var q = new Queue<int[]>();
        var visited = new int[grid.Length, grid[0].Length];
        var perimeter = 0;
        for(var y = 0; y < grid.Length; y++){
            for(var x = 0; x < grid[0].Length; x++){
                if(grid[y][x] == 0) continue;
                q.Enqueue(new []{y, x});
                while(q.Count > 0) {
                    var item = q.Dequeue();
                    var y1 = item[0];
                    var x1 = item[1];
                    if(visited[y1, x1] == 1) continue;
                    //add adjecent island block to the queue
                    //calculate the perimeter at the same time
                    foreach(var n in neighbours) {
                        if(y1 + n[0] >=0 && y1 + n[0] < grid.Length
                          && x1 + n[1] >=0 && x1 + n[1] < grid[0].Length){
                            if(grid[y1 + n[0]][x1 + n[1]] == 1){
                                q.Enqueue(new []{y1 + n[0], x1 + n[1]});
                            }
                            else{//neighbour is water, so advance perimeter by 1
                                perimeter++;
                            }
                        }
                        else{//a boarder of the grid found
                            perimeter++;
                        }
                    }
                    visited[y1, x1] = 1;
                }
            }
        }
        return perimeter;
    }
    
    private List<int[]> neighbours = new List<int[]>{
        new []{1, 0}, new []{-1, 0}, new []{0, 1}, new []{0, -1}
    };
}