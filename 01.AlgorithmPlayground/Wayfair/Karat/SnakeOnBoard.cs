using System;
using System.Collections.Generic;

public class SnackOnBoard {
    char[,] board1 = new char[,]{{'+', '+', '+', '+', '+', '+', '+', '0', '0'},
                                 {'+', '+', '0', '0', '0', '0', '0', '+', '+'},
                                 {'0', '0', '0', '0', '0', '+', '+', '0', '+'},
                                 {'+', '+', '0', '+', '+', '+', '+', '0', '0'},
                                 {'+', '+', '0', '0', '0', '0', '0', '0', '+'},
                                 {'+', '+', '0', '+', '+', '0', '+', '0', '+'}};
    char[,] board2 = new char[,]{{'+', '+', '+', '+', '+', '+', '+'},
                                 {'0', '0', '0', '0', '+', '0', '+'},
                                 {'+', '0', '+', '0', '+', '0', '0'},
                                 {'+', '0', '0', '0', '+', '+', '+'},
                                 {'+', '+', '+', '+', '+', '+', '+'}};
    char[,] board3 = new char[,]{{'+', '+', '0', '+', '+', '+', '+', '0', '0'},
                                 {'+', '+', '0', '0', '0', '0', '0', '+', '+'},
                                 {'0', '0', '0', '0', '0', '+', '+', '0', '+'},
                                 {'+', '+', '0', '+', '+', '+', '+', '0', '0'},
                                 {'0', '0', '0', '0', '0', '0', '0', '0', '0'},
                                 {'+', '+', '0', '+', '+', '0', '+', '0', '+'}};
    public int[] FindNearestExit(char[,] board, int[] start){
        int m = board.GetLength(0), n = board.GetLength(1);
        var q = new Queue<int[]>();
        var neighbors = new int[][]{
            new []{1,0}, new []{0,1}, new []{-1, 0}, new []{0, -1} 
        };
        q.Enqueue(start);
        var ans = new int[]{0,0};
        while(q.Count > 0) {
            var cur = q.Dequeue();
            int r = cur[0], c = cur[1];
            if(board[r,c] == '+')
                continue;
            if(r != start[0] && c != start[1] && 
                (r == 0 || r == m-1 || c == 0 || c == n-1)){
                ans[0] = r;
                ans[1] = c;
                break;
            }
            board[r,c] = '+';
            foreach(var neighbor in neighbors){
                int nr = r+neighbor[0], nc = c+neighbor[1];
                if(nr < 0 || nr >= m || nc < 0 || nc >= n) continue;
                q.Enqueue(new int[]{nr, nc});
            }
        }
        Console.WriteLine($"[{ans[0]},{ans[1]}]");
        return ans;
    }

    public void Test_FindPassableLanes(){
        var ans1 = FindPassableLanes(board1);
        var ans2 = FindPassableLanes(board2);
        var ans3 = FindPassableLanes(board3);
        Print_FindPassableLanes(ans1);
        Print_FindPassableLanes(ans2);
        Print_FindPassableLanes(ans3);
    }

    private void Print_FindPassableLanes(List<List<int>> ans){
        Console.WriteLine($"Horizontal: [{string.Join(',', ans[0])}]");
        Console.WriteLine($"Vertical  : [{string.Join(',', ans[1])}]");
    }

    public void Test_FindNearestExit(){
        FindNearestExit(board1, new int[]{2, 0});
    }

    public List<List<int>> FindPassableLanes(char[,] board){
        var ans = new List<List<int>>();
        var ansHorizontal = new List<int>();
        int m = board.GetLength(0), n = board.GetLength(1);
        Console.WriteLine($"{m},{n}");
        for(var i = 0; i < m; ++i){
            var passable = true;
            for(var j = 0; j < n; ++j){
                if(board[i,j] == '+'){
                    passable = false;
                    break;
                }
            }
            if(passable)
                ansHorizontal.Add(i);
        }
        var ansVertical = new List<int>();
        for(var j = 0; j < n; ++j){
            var passable = true;
            for(var i = 0; i < m; ++i){
                if(board[i,j] == '+'){
                    passable = false;
                    break;
                }
            }
            if(passable)
                ansVertical.Add(j);
        }
        ans.Add(ansHorizontal);
        ans.Add(ansVertical);
        return ans; 
    }
}