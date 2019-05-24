public class Solution {
    public void Solve(char[][] board) {
        if(board.Length == 0 || board[0].Length == 0)
            return;
        
        //boundary solution:
        // step 1: turn O areas that connect to boundary to 'S', BFS or DFS both are ok
        // step 2: turn other O to X, and turn all S to O
        
        //step 1
        for(var x = 0; x < board[0].Length; x++){
            if(board[0][x] == 'O')
                DfsHelper(board, x, 0);
            if(board[board.Length - 1][x] == 'O')
                DfsHelper(board, x, board.Length - 1);
        }
        
        for(var y = 0; y < board.Length; y++){
            if(board[y][0] == 'O')
                DfsHelper(board, 0, y);
            if(board[y][board[0].Length - 1] == 'O')
                DfsHelper(board, board[0].Length - 1, y);
        }
        
        //step 2
        for(var y = 0; y < board.Length; y++){
            for(var x = 0; x < board[0].Length; x++){
                if(board[y][x] == 'O')
                    board[y][x] = 'X';
                if(board[y][x] == 'S')
                    board[y][x] = 'O';
            }
        }
    }
    
    // recursion's call stack can be leveraged by DFS
    // change the value while doing the traversal so as to record visited elements
    private void DfsHelper(char[][] board, int x, int y){
        
        board[y][x] = 'S';
        if(y > 0 && board[y - 1][x] == 'O')
            DfsHelper(board, x, y - 1);
        if(y < board.Length - 1 && board[y + 1][x] == 'O')
            DfsHelper(board, x, y + 1);
        if(x > 0 && board[y][x - 1] == 'O')
            DfsHelper(board, x - 1, y);
        if(x < board[0].Length - 1 && board[y][x + 1] == 'O')
            DfsHelper(board, x + 1, y);
    }
}