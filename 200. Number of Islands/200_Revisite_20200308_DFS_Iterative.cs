public class Solution {
    public int NumIslands(char[][] grid) {
        //DFS iterative with stack approach, revisited 2020/03/08
        if(grid.Length == 0 || grid[0].Length == 0) return 0;
        var st = new Stack<int[]>();
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
                st.Push(new []{x, y});
                while(st.Count > 0){
                    var item = st.Pop();
                    curx = item[0];
                    cury = item[1];
                    //skip adding same element, if current element is already turned to '0' 
                    if(grid[cury][curx] == '0') continue;
                    grid[cury][curx] = '0';
                    foreach(var n in neighbours){
                        if(curx + n[0] >= 0 && curx + n[0] < lx && cury + n[1] >= 0 && cury + n[1] < ly){
                            if(grid[cury + n[1]][curx + n[0]] == '1')
                                st.Push(new []{curx + n[0], cury + n[1]});
                        }
                    }
                }
                result++;
            }
        }
        return result;
    }
}