public class Solution {
        public int _minInsert;
        public int FindMinStep(string board, string hand)
        {
            //optimization: the max insert count is hand.Length, so set the initial value to hand.Length+1
            _minInsert = hand.Length + 1;
            //counting chars in hand
            var chand = new int[26];
            foreach(var c in hand)
                chand[c - 'A']++;
            DfsHelper(board, chand, 0);
            return _minInsert == hand.Length + 1 ? -1 :_minInsert;
        }

        private void DfsHelper(string board, int[] chand, int insertCount)
        {
            //optimization, no need to continue if already inserted count is equal or even greater than current minInsert count found so far
            if(insertCount >= _minInsert) return;

            if(string.IsNullOrEmpty(board)){
                _minInsert = Math.Min(_minInsert, insertCount);
                return;
            }

            //!!! this is the tricky part, declare 2 var in the for loop and make the slower one(i) catch-up the faster one(j) at the end of the loop
            for(int i = 0, j = 0; j <= board.Length; ++j){
                if(j < board.Length && board[j] == board[i]) continue;
                var need = 3 - (j - i);
                if(chand[board[i] - 'A'] >= need){
                    chand[board[i] - 'A'] -= need;
                    var newBoard = Insert(board, new string(board[i], need), i);
                    DfsHelper(newBoard, chand, insertCount + need);
                    chand[board[i] - 'A'] += need;
                }
                i = j;
            }
            
        }

        private string Insert(string board, string c, int index){
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