public class Solution {
    public int IslandPerimeter(int[][] grid) {
        var ly = grid.Length;
        var lx = grid[0].Length;
        //var visited = new int[ly][lx];
        var neighbours = new List<int[]> {
            new []{1, 0}, new []{-1, 0}, new []{0, 1}, new []{0, -1}
        };
        var perimeter = 0;
        for(var y = 0; y < ly; y++){
            for(var x = 0; x < lx; x++){
                if(grid[y][x] == 0) continue;
                foreach(var n in neighbours){
                    if(y + n[0] >= 0 && y + n[0] < ly && x + n[1] >=0 && x + n[1] < lx){
                        if(grid[y + n[0]][x + n[1]] == 0){//water
                            perimeter++;
                        }
                    }
                    else{//out of the boarder, meaning there must be part of the perimter
                        perimeter++;
                    }
                }
            }
        }
        return perimeter;
        
    }
}