public class Solution {
    public char[][] UpdateBoard(char[][] board, int[] click) {
        //BFS interative
        //clicked a mine
        if(board[click[0]][click[1]] == 'M'){
            board[click[0]][click[1]] = 'X';
            return board;
        } 
        
        //clicked an blank square
        //8 way adjacent neighbours
        var neighbours = new []{
            new []{1, 0},
            new []{1, 1},
            new []{0, 1},
            new []{-1, 1},
            new []{-1, 0},
            new []{-1, -1},
            new []{0, -1},
            new []{1, -1},
        };
        var q = new Queue<int[]>();
        q.Enqueue(click);
        while(q.Count > 0){
            var item = q.Dequeue();
            var iy = item[0];
            var ix = item[1];
            if(board[iy][ix] == 'B' || Char.IsDigit(board[iy][ix]) || board[iy][ix] == 'M') continue;
            var mineCount = 0;
            var blankNeighbours = new List<int[]>();
            foreach(var n in neighbours){
                if(iy + n[0] >= 0 && iy + n[0] < board.Length
                  && ix + n[1] >= 0 && ix + n[1] < board[0].Length){
                    if(board[iy + n[0]][ix + n[1]] == 'M')
                        mineCount++;
                    if(board[iy + n[0]][ix + n[1]] == 'E')
                        blankNeighbours.Add(new []{iy + n[0], ix + n[1]});
                }
            }

            if(mineCount > 0){
                board[iy][ix] = (char)('0' + mineCount);
                continue;
            }

            //mineCount == 0
            board[iy][ix] = 'B';
            foreach(var blank in blankNeighbours)
                q.Enqueue(blank);
        }
            
        
        return board;
    }
}