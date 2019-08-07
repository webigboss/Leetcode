public class Solution {
    public int NumIslands(char[][] grid) {
        //DFS iterative approach
        var st = new Stack<int[]>();
        var count = 0;
        for(var y = 0; y < grid.Length; y++){
            for(var x = 0; x < grid[0].Length; x++){
                if(grid[y][x] == '1'){
                    st.Push(new []{x, y});
                    while(st.Count > 0){
                        var elem = st.Pop();
                        var x1 = elem[0];
                        var y1 = elem[1];
                        grid[y1][x1] = '0';
                        if(y1 > 0 && grid[y1 - 1][x1] == '1')
                            st.Push(new []{x1, y1 - 1});
                        if(y1 < grid.Length - 1 && grid[y1 + 1][x1] == '1')
                            st.Push(new []{x1, y1 + 1});
                        if(x1 > 0 && grid[y1][x1 - 1] == '1')
                            st.Push(new []{x1 - 1, y1});
                        if(x1 < grid[0].Length - 1 && grid[y1][x1 + 1] == '1')
                            st.Push(new []{x1 + 1, y1});
                    }
                    count++;
                }
            }
        }
        return count;
    }
}