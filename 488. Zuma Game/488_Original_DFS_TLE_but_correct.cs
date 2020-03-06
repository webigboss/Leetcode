public class Solution {
    public int _minInsert;
    public int FindMinStep(string board, string hand)
    {
        //optimization: the max insert count is hand.Length, so set the initial value to hand.Length+1
        _minInsert = hand.Length + 1;
        var usedH = new bool[hand.Length];
        DfsHelper(board, hand, usedH, 0);
        return _minInsert == hand.Length + 1 ? -1 :_minInsert;
    }

    private void DfsHelper(string board, string hand, bool[]usedH, int insertCount)
    {
        //optimization, no need to continue if already inserted count is equal or even greater than current minInsert count found so far
        if(insertCount >= _minInsert) return;
        
        if(string.IsNullOrEmpty(board)){
            _minInsert = Math.Min(_minInsert, insertCount);
            return;
        }

        for(var i = 0; i < hand.Length; i++){
            if(usedH[i]) continue;
            usedH[i] = true;
            for(var j = 0; j <= board.Length; j++){
                //!!!shouldn't do this optimizaiton, test case RRWWRRBBRR WB will fail!!!
                //if(j > 0 && j < board.Length && board[j] == board[j - 1]) continue;
                var newBoard = Insert(board, hand[i], j);
                DfsHelper(newBoard, hand, usedH, insertCount + 1);
            }
            usedH[i] = false;
        }
    }

    private string Insert(string board, char c, int index){
        if(index > board.Length) return board;
        //insert to the left of board[index], so index could be 0-board.Length
        var newBoard = board.Substring(0, index) + c + board.Substring(index, board.Length - index);
        var hi = 0;
        var lo = 0;
        var count = 0;
        while(true){
            if(hi == newBoard.Length){
                if(count >=3){
                    newBoard = newBoard.Substring(0, lo);
                }
                break;
            }
            if(newBoard[lo] == newBoard[hi]){
                hi++;
                count++;
            }
            else{
                if(count >= 3){
                    newBoard = newBoard.Substring(0, lo) + newBoard.Substring(hi);
                    hi = 0;
                }
                lo = hi;
                count = 0;
            }
        }
        return newBoard;
    }
}