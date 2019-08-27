public class Solution {
    public int CountBattleships(char[][] board) {
        //one pass with constant space complexity approach
        //count the first cell, which is the top-left element
        var result = 0;
        for(var y = 0; y < board.Length; y++){
            for(var x = 0; x < board[0].Length; x++){
                if(x > 0 && board[y][x - 1] == 'X') continue;
                if(y > 0 && board[y - 1][x] == 'X') continue;
                if(board[y][x] == 'X') 
                    result++;
            }
        }
        return result;
    }
}