public class Solution {
    public int CountBattleships(char[][] board) {
        // DFS interative approach
        var st = new Stack<int[]>();
        var result = 0;
        var neighbours = new []{
            new []{-1, 0}, new []{1, 0}, new []{0, -1}, new []{0, 1}
        };
        for(var y = 0; y < board.Length; y++){
            for(var x = 0; x < board[0].Length; x++){
                if(board[y][x] == 'X'){
                    st.Push(new []{x, y});
                    while(st.Count > 0){
                        var indexes = st.Pop();
                        var curX = indexes[0];
                        var curY = indexes[1];
                        board[curY][curX] = '.';
                        foreach(var n in neighbours){
                            if(curX + n[0] >= 0 && curX + n[0] < board[0].Length
                              && curY + n[1] >= 0 && curY + n[1] < board.Length
                              && board[curY + n[1]][curX + n[0]] == 'X')
                                st.Push(new []{curX + n[0], curY + n[1]});
                        }
                    }
                    result++;
                }
            }
        }
        return result;
    }
}