using System;

namespace AlgorithmPlayground
{
    public class ZumaGame
    {
        public ZumaGame(){
            var board = "WWRRBBWW";
            var hand = "WRBRW"; 
            var result = FindMinStep(board, hand);
        }
        public int _minInsert;
        public int FindMinStep(string board, string hand)
        {
            _minInsert = int.MaxValue;
            var usedB = new bool[board.Length];
            var usedH = new bool[hand.Length];
            DfsHelper(board, hand, usedB, usedH, 0, board.Length);
            return _minInsert == int.MaxValue ? -1 :_minInsert;
        }

        private void DfsHelper(string board, string hand, bool[] usedB, bool[] usedH, int insertCount, int remaining)
        {
            if (remaining == 0)
            {
                _minInsert = Math.Min(_minInsert, insertCount);
                return;
            }

            for (var i = 0; i < hand.Length; i++)
            {
                if (usedH[i]) continue;
                usedH[i] = true;
                //make sure only inserting onece for a group. e.g.inserting R to WRRB, 
                //there are 3 rows to insert to form a group. W^R^R^B, inserting in any of the 3 rows 
                //result in same case in the next recursion, so only need to call once  
                var canSkip = new bool[board.Length];
                for (var j = 0; j < board.Length; j++)
                {
                    if (usedB[j] || canSkip[j] || board[j] != hand[i])
                    {
                        continue;
                    }
                    //copy the array instead of update in place
                    //to avoid unwanted update caused by reference in downstream recursion
                    var usedBCopy = new bool[usedB.Length];
                    Array.Copy(usedB, usedBCopy, 0);
                    var count = 1;
                    var cur = 0;

                    //searching leftward
                    cur = j - 1;
                    while (cur >= 0)
                    {
                        if (usedBCopy[cur])
                        {
                            cur--;
                            continue;
                        }
                        if (board[cur] == board[j])
                        {
                            usedBCopy[cur] = true;
                            count++;
                            cur--;
                        }
                        else break;
                    }

                    //searching rightward
                    cur = j + 1;
                    while (cur < board.Length)
                    {
                        if (usedBCopy[cur])
                        {
                            cur++;
                            continue;
                        }
                        if (board[cur] == board[j])
                        {
                            usedBCopy[cur] = true;
                            //since the for interation only from left to right, we calculate canSkip array only in the rightward search
                            canSkip[cur] = true;
                            count++;
                            cur++;
                        }
                        else break;
                    }
                    if (count > 1)
                    {
                        DfsHelper(board, hand, usedBCopy, usedH, insertCount + 1, remaining - count);
                    }
                }
                usedH[i] = false;
            }
        }
    }
}