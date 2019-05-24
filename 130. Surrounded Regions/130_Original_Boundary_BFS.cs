public class Solution {
    public void Solve(char[][] board) {
        //boundary solution: (BFS)
        // step 1: turn O areas that connect to boundary to 'S', BFS or DFS both are ok
        // step 2: turn other O to X, and turn all S to O
        if(board.Length == 0 || board[0].Length == 0)
            return;
        
        //step 1
        for(var x = 0; x < board[0].Length; x++){
            if(board[0][x] == 'O')
                BfsHelper(board, x, 0);
            if(board[board.Length - 1][x] == 'O')
                BfsHelper(board, x, board.Length - 1);
        }
        
        for(var y = 0; y < board.Length; y++){
            if(board[y][0] == 'O')
                BfsHelper(board, 0, y);
            if(board[y][board[0].Length - 1] == 'O')
                BfsHelper(board, board[0].Length - 1, y);
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
    
    // cannot use recursion, instead use a queue to implement BFS
    // no need to extra space to memorize the visited element, we can just change its value directly
    // due to the nature of this problem
    private void BfsHelper(char[][] board, int x, int y){
        var q = new Queue<int[]>();
        q.Enqueue(new []{x , y});
        
        while(q.Count > 0){
            var indices = q.Dequeue();
            x = indices[0];
            y = indices[1];
            if(board[y][x] == 'S')
                continue;
            board[y][x] = 'S';
            if(y > 0 && board[y - 1][x] == 'O')
                q.Enqueue(new []{x, y - 1});
            if(y < board.Length - 1 && board[y + 1][x] == 'O')
                q.Enqueue(new []{x, y + 1});
            if(x > 0 && board[y][x - 1] == 'O')
                q.Enqueue(new []{x - 1, y});
            if(x < board[0].Length - 1 && board[y][x + 1] == 'O')
                q.Enqueue(new []{x + 1, y});
        }
    }
}