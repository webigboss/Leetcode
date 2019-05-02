public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var ht = new Hashtable();
        var valid = true;
        for(var y = 0; y <= board.Length - 1; y++){
            for(var x = 0; x <= board[y].Length - 1; x++){
                if(ht.ContainsKey(board[y][x]))
                    return false;
                if(board[y][x] != '.')
                    ht.Add(board[y][x], null);
            }
            ht.Clear();
        }
        
        for(var x = 0; x <= board[0].Length - 1; x++){
            for(var y = 0; y <= board.Length - 1; y++){
                if(ht.ContainsKey(board[y][x]))
                    return false;
                if(board[y][x] != '.')
                    ht.Add(board[y][x], null);
            }
            ht.Clear();
        }
       
        for(var i = 0; i < 3; i++){
            for(var j = 0; j < 3; j++){
                for(var y = 0; y < 3; y++){
                    for(var x = 0; x < 3; x++){
                        if(ht.ContainsKey(board[i * 3 + y][j * 3 + x]))
                            return false;
                        if(board[i * 3 + y][j * 3 + x] != '.')
                            ht.Add(board[i * 3 + y][j * 3 + x], null);
                    }
                }
                ht.Clear();
            }
        }
        return valid;
    }
}