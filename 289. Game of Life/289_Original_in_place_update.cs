public class Solution {
    public void GameOfLife(int[][] board) {
        // define two intermetiate state to mark a cell is going to die(2) and is going to live again(-1), so that we can update in place
        // 8 directions of neighbors, [x, y]
        var test = new int[] {1,2,3,4};
        var neighbors = new int[][] { 
            new int[]{0, -1}, 
            new int[]{1, -1}, 
            new int[]{1, 0}, 
            new int[]{1, 1}, 
            new int[]{0, 1}, 
            new int[]{-1, 1}, 
            new int[]{-1, 0}, 
            new int[] {-1, -1} 
        };
        int liveCount;
        //1. in place update with 2 additional intermediate status value
        for(var y = 0; y < board.Length; y++){
            for(var x = 0; x < board[0].Length; x++){
                liveCount = 0;
                foreach(var n in neighbors){
                    if(x + n[0] >= 0 && x + n[0] < board[0].Length && y + n[1] >= 0 && y + n[1] < board.Length){
                        if(board[y + n[1]][x + n[0]] >= 1) liveCount++;
                    }    
                }
                if(board[y][x] >= 1 && (liveCount < 2 || liveCount > 3))
                    board[y][x] = 2;
                if(board[y][x] <= 0 && liveCount == 3)
                    board[y][x] = -1;
            }
        }
        
        //2. update the element with intermediate values to the die or live value
        for(var y = 0; y < board.Length; y++){
            for(var x = 0; x < board[0].Length; x++){
                if(board[y][x] == 2) board[y][x] = 0;
                if(board[y][x] == -1) board[y][x] = 1;
            }
        }
    }
}