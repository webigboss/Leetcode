using System;
using System.Text;

namespace AlgorithmPlayground{
    public class SudoKuSolver {

        public SudoKuSolver(){
            var board = new char[][]{
                new []{'5','3','.','.','7','.','.','.','.'},
                new []{'6','.','.','1','9','5','.','.','.'},
                new []{'.','9','8','.','.','.','.','6','.'},
                new []{'8','.','.','.','6','.','.','.','3'},
                new []{'4','.','.','8','.','3','.','.','1'},
                new []{'7','.','.','.','2','.','.','.','6'},
                new []{'.','6','.','.','.','.','2','8','.'},
                new []{'.','.','.','4','1','9','.','.','5'},
                new []{'.','.','.','.','8','.','.','7','9'}
            };
            SolveSudoku(board);
            for(var i = 0; i < board.Length; i++){
                var sb = new StringBuilder();
                for(var j = 0; j < board[0].Length; j++){
                    sb.Append(board[i][j]).Append(',');
                }
                Console.WriteLine(sb);
            }
        }

        private bool isSolved;
        public void SolveSudoku(char[][] board) {
            isSolved = false;
            var vVisited = new int[9, 9];
            var hVisited = new int[9, 9];
            var tbtVisited = new int[9,9];
            //1. pre-populdate the 3 visited 2D array
            for(var y = 0; y < board.Length; y++){
                for(var x = 0; x < board[0].Length; x++){
                    var num = board[y][x] - '0';
                    if(board[y][x] != '.'){
                        hVisited[y, num - 1] = num;
                        vVisited[x, num - 1] = num;
                        Set3b3Visited(x, y, num, tbtVisited);
                    }  
                }
            }
            BacktrackingHelper(board, hVisited, vVisited, tbtVisited);
        }
        
        private void BacktrackingHelper(char[][] board, int[,] hVisited, int[,] vVisited, int[,] tbtVisited){
            if(isSolved) return;
            if(IsSodokuSolved(hVisited, vVisited, tbtVisited)){
                isSolved = true;
                return;
            }

            for(var y = 0; y < board.Length; y++){
                for(var x = 0; x < board[0].Length; x++){
                    if(board[y][x] != '.') continue;
                    for(var i = 0; i < 9; i++){
                        if(hVisited[y, i] > 0 || vVisited[x, i] > 0 || Is3b3Visited(x, y, i + 1, tbtVisited))
                            continue;
                        hVisited[y, i] = i + 1;
                        vVisited[x, i] = i + 1;
                        Set3b3Visited(x, y, i + 1, tbtVisited);
                        board[y][x] = (i + 1).ToString()[0];
                        BacktrackingHelper(board, hVisited, vVisited, tbtVisited);
                        if(isSolved) return;
                        hVisited[y, i] = 0;
                        vVisited[x, i] = 0;
                        Set3b3Visited(x, y, i + 1, tbtVisited, true);
                        board[y][x] = '.';
                    }
                    if(board[y][x]== '.') return;
                }
            }
        }

        private bool IsSodokuSolved(int[,] hVisited, int[,] vVisited, int[,] tbtVisited){
            for(var i = 0; i < 9; i++){
                for(var j = 0; j < 9; j++){
                    if(hVisited[i, j] == 0) return false;
                    if(vVisited[i, j] == 0) return false;
                    if(tbtVisited[i, j] == 0) return false;
                }
            }
            return true;
        }
        
        private bool Is3b3Visited(int x, int y, int num, int[,] tbtVisited){
            // index for getting which 3x3
            var i = 3 * (y / 3) + x / 3;
            return tbtVisited[i, num - 1] > 0;
        }
        
        private void Set3b3Visited(int x, int y, int num, int[,] tbtVisited, bool setToUnVisited = false){
            if(setToUnVisited)
                tbtVisited[3 * (y / 3) + x / 3, num - 1] = 0;
            else
                tbtVisited[3 * (y / 3) + x / 3, num - 1] = num;
        }
    }
}