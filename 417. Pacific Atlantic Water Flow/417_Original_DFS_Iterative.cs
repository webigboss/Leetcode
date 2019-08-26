public class Solution {
    public IList<IList<int>> PacificAtlantic(int[][] matrix) {
        var result = new List<IList<int>>();
        if(matrix.Length == 0 || matrix[0].Length == 0)
            return result;
        var neighbours = new []{
          new []{0, -1}, new []{0, 1}, new []{-1, 0}, new []{1, 0}  
        };
        //0: unvisited, 1: cannot flow to both ocean, 2: can flow to Pacific, 3: can flow to Atlantic, 4: can flow to both oceans
        var flows = new int[matrix[0].Length, matrix.Length];
        var st = new Stack<int[]>();
        
        for(var y = 0; y < matrix.Length; y++){
            for(var x = 0; x < matrix[0].Length; x++){
                var visited = new bool[matrix[0].Length, matrix.Length];
                st.Clear();
                st.Push(new []{x, y});
                while(st.Count > 0){
                    var indexes = st.Pop();
                    var curX = indexes[0];
                    var curY = indexes[1];
                    if(visited[curX, curY]) continue;
                    visited[curX, curY] = true;
                    if(flows[curX, curY] == 1) continue;
                    if(flows[curX, curY] == 4){
                        st.Clear();
                        flows[x, y] = 4;
                        result.Add(new List<int>{y, x});
                        break;
                    }
                    if(curX == 0 || curY == 0){
                        if(flows[x, y] == 3){
                            st.Clear();
                            flows[x, y] = 4;
                            result.Add(new List<int>{y, x});
                            break;
                        }
                        flows[x, y] = 2;
                    }
                    if(curX == matrix[0].Length - 1 || curY == matrix.Length - 1){
                        if(flows[x, y] == 2){
                            st.Clear();
                            flows[x, y] = 4;
                            result.Add(new List<int>{y, x});
                            break;
                        }
                        flows[x, y] = 3;
                    }
                    foreach(var neighbour in neighbours){
                        if(curX + neighbour[0] >= 0 && curX + neighbour[0] < matrix[0].Length
                          && curY + neighbour[1] >= 0 && curY + neighbour[1] < matrix.Length
                          && matrix[curY + neighbour[1]][curX + neighbour[0]] <= matrix[curY][curX]){
                            st.Push(new []{curX + neighbour[0], curY + neighbour[1]});
                        }
                    }
                }
            }
        }
        return result;
    }
}