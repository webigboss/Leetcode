using System.Collections.Generic;

namespace AlgorithmPlayground
{
    public class NumberofIsLands
    {

        public NumberofIsLands()
        {
            var rows = 5;
            var columns = 6;

            var grid = new int[,]{
                {0,1,1,1,0,0},
                {0,0,1,1,0,0},
                {0,0,0,0,0,1},
                {1,1,0,0,0,1},
                {0,1,0,0,1,1},
            };
            var result = numberAmazonTreasureTrucks(rows, columns, grid);
            
        }

        public int numberAmazonTreasureTrucks(int rows, int column, int[,] grid)
        {
            // WRITE YOUR CODE HERE
            //rows: y, column: x

            //iterative BFS with a queue

            if (rows == 0 || column == 0) return 0;
            var q = new Queue<int[]>();
            var result = 0;
            int curx, cury;
            var neighours = new[]{
             new [] {1, 0},
             new [] {-1, 0},
             new [] {0, 1},
             new [] {0, -1}
         };
            for (var y = 0; y < rows; ++y)
            {
                for (var x = 0; x < column; ++x)
                {
                    if (grid[y, x] == 0) continue;
                    q.Enqueue(new[] { x, y });
                    while (q.Count > 0)
                    {
                        var item = q.Dequeue();
                        curx = item[0];
                        cury = item[1];
                        if (grid[cury, curx] == 0) continue;
                        grid[cury, curx] = 0;
                        //boundary check
                        foreach (var n in neighours)
                        {
                            if (curx + n[0] >= 0 && curx + n[0] < rows && cury + n[1] >= 0 && cury + n[1] < column
                               && grid[cury + n[1], curx + n[0]] == 1)
                            {
                                q.Enqueue(new[] { curx + n[0], cury + n[1] });
                            }
                        }
                    }
                    result++;
                }
            }
            return result;
        }

        public int NumIsLands_BFS_Iterative_Queue(char[][] grid)
        {
            //BFS with queue approach, revisited 2020/03/08
            if (grid.Length == 0 || grid[0].Length == 0) return 0;
            var q = new Queue<int[]>();
            var result = 0;
            var ly = grid.Length;
            var lx = grid[0].Length;
            int curx, cury;
            var neighbours = new[]{
            new []{1, 0},
            new []{-1, 0},
            new []{0, 1},
            new []{0, -1}
        };
            for (var y = 0; y < ly; ++y)
            {
                for (var x = 0; x < lx; ++x)
                {
                    if (grid[y][x] == '0') continue;
                    q.Enqueue(new[] { x, y });
                    while (q.Count > 0)
                    {
                        var item = q.Dequeue();
                        curx = item[0];
                        cury = item[1];
                        //!! checking if current element is visited, this is important for BFS to optimize by avoid adding same element into queue;
                        if (grid[cury][curx] == '0') continue;
                        grid[cury][curx] = '0';
                        foreach (var n in neighbours)
                        {
                            if (curx + n[0] >= 0 && curx + n[0] < lx && cury + n[1] >= 0 && cury + n[1] < ly)
                            {
                                if (grid[cury + n[1]][curx + n[0]] == '1')
                                    q.Enqueue(new[] { curx + n[0], cury + n[1] });
                            }
                        }
                    }
                    result++;
                }
            }
            return result;
        }

        public int NumIsLands_DFS_Iterative_Stack(char[][] grid)
        {
            //DFS iterative with stack approach, revisited 2020/03/08
            if (grid.Length == 0 || grid[0].Length == 0) return 0;
            var st = new Stack<int[]>();
            var result = 0;
            var ly = grid.Length;
            var lx = grid[0].Length;
            int curx, cury;
            var neighbours = new[]{
            new []{1, 0},
            new []{-1, 0},
            new []{0, 1},
            new []{0, -1}
        };
            for (var y = 0; y < ly; ++y)
            {
                for (var x = 0; x < lx; ++x)
                {
                    if (grid[y][x] == '0') continue;
                    st.Push(new[] { x, y });
                    while (st.Count > 0)
                    {
                        var item = st.Pop();
                        curx = item[0];
                        cury = item[1];
                        //skip adding same element, if current element is already turned to '0' 
                        if (grid[cury][curx] == '0') continue;
                        grid[cury][curx] = '0';
                        foreach (var n in neighbours)
                        {
                            if (curx + n[0] >= 0 && curx + n[0] < lx && cury + n[1] >= 0 && cury + n[1] < ly)
                            {
                                if (grid[cury + n[1]][curx + n[0]] == '1')
                                    st.Push(new[] { curx + n[0], cury + n[1] });
                            }
                        }
                    }
                    result++;
                }
            }
            return result;
        }
    }
}