public class Solution {
    public bool Exist(char[][] board, string word) {
        var exist = new List<bool>();
        for(var x = 0; x < board[0].Length; x++){
            for(var y = 0 ; y < board.Length; y++){
                WordSearchBacktracking(board, x, y, 0, new bool[board[0].Length, board.Length], word, exist);
            }
        }
        return exist.Count != 0;
    }
    
    private void WordSearchBacktracking(char[][] board, int x, int y, int cur, bool[,] used, string word, List<bool> exist){
        if(exist.Count != 0)
            return;
        if(board[y][x] != word[cur])
            return;
        else{
            used[x, y] = true;
            //board[x,y] == word[cur]
            if(cur == word.Length - 1){
                exist.Add(true);
                return;
            }
            
            //1. move up
            if(y > 0 && !used[x, y - 1]){
                WordSearchBacktracking(board, x, y - 1, cur + 1, used, word, exist);
                used[x, y - 1] = false;
            }
            //2. move down
            if(y < board.Length - 1 && !used[x, y + 1]){
                WordSearchBacktracking(board, x, y + 1, cur + 1, used, word, exist);
                used[x, y + 1] = false;
            }
            //3. move left
            if(x > 0 && !used[x - 1, y]){
                WordSearchBacktracking(board, x - 1, y, cur + 1, used, word, exist);
                used[x - 1, y] = false;
            }
            //4. move right
            if(x < board[0].Length - 1 && !used[x + 1, y]){
                WordSearchBacktracking(board, x + 1, y, cur + 1, used, word, exist);
                used[x + 1, y] = false;
            }
        } 
    }
}