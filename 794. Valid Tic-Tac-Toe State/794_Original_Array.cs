public class Solution {
    public bool ValidTicTacToe(string[] board) {
        //X will be either equals or greater than O by 1;
        //the board will not lead to end game
        
        //1. count X and O
        int cx, co;
        cx = co = 0;
        for(var i = 0; i < 3; ++i){
            for(var j = 0; j < 3; ++j){
                if(board[i][j] == 'X') cx++;
                if(board[i][j] == 'O') co++;
            }
        }
        if(cx - co > 1 || cx - co < 0) return false;
        var isEqual = cx == co;
        //2. check if it's an end game
        cx = co = 0;
        for(var i = 0; i < 3; ++i){
            if(board[i] == "XXX") cx++;
            if(board[i] == "OOO") co++;
        }
        for(var j = 0; j < 3; ++j){
            if(board[0][j] == 'X' && board[1][j] == 'X' && board[2][j] == 'X')
                cx++;
            if(board[0][j] == 'O' && board[1][j] == 'O' && board[2][j] == 'O')
                co++;
        }
        
        //diagonal
        if(board[0][0] == 'X' && board[1][1] == 'X' && board[2][2] == 'X')
            cx++;
        if(board[0][0] == 'O' && board[1][1] == 'O' && board[2][2] == 'O')
            co++;
        if(board[0][2] == 'X' && board[1][1] == 'X' && board[2][0] == 'X')
            cx++;
        if(board[0][2] == 'O' && board[1][1] == 'O' && board[2][0] == 'O')
            co++;
        
        if(cx >= 1 && co >= 1 
           || isEqual && cx > 0
           || !isEqual && co > 0) return false;
        return true;
    }
}