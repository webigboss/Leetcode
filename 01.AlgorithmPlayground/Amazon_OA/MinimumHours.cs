using System;
using System.Collections.Generic;
// IMPORT LIBRARY PACKAGES NEEDED BY YOUR PROGRAM
// SOME CLASSES WITHIN A PACKAGE MAY BE RESTRICTED
// DEFINE ANY CLASS AND METHOD NEEDED
// CLASS BEGINS, THIS CLASS IS REQUIRED
namespace AlgorithmPlayground
{
    public class MinimumHours
    {
        public MinimumHours()
        {
            var rows = 5;
            var columns = 6;

            var grid = new int[,]{
                {1,1,1,1,1,1},
                {1,1,1,1,1,1},
                {1,1,1,1,1,1},
                {1,1,1,1,1,1},
                {1,1,1,1,1,1},
            };
            var result = FindMinimumHours(rows, columns, grid);
        }
        // METHOD SIGNATURE BEGINS, THIS METHOD IS REQUIRED
        public int FindMinimumHours(int rows, int columns, int[,] grid)
        {
            // WRITE YOUR CODE HERE
            //iterative BFS with a queue
            var q = new Queue<int[]>();
            var result = -1;
            var neighbours = new[]{
            new []{1, 0},
            new []{-1, 0},
            new []{0, 1},
            new []{0, -1}
        };
            int curx, cury, curStep;
            int[] item;
            //1. collect all the servers that has file (with value 1) into the queue
            for (var y = 0; y < rows; ++y)
            {
                for (var x = 0; x < columns; ++x)
                {
                    if (grid[y, x] == 0) continue;
                    foreach (var n in neighbours)
                    {
                        if (x + n[0] >= 0 && x + n[0] < columns && y + n[1] >= 0 && y + n[1] < rows && grid[y + n[1] , x+ n[0]] == 0)
                            q.Enqueue(new int[]{y + n[1], x + n[0], 1});
                    }
                }
            }

            //2. BFS operation
            while (q.Count > 0)
            {
                item = q.Dequeue();
                cury = item[0];
                curx = item[1];
                curStep = item[2];
                if(grid[cury, curx] == 1) continue;
                grid[cury, curx] = 1;
                result = Math.Max(result, curStep);
                foreach (var n in neighbours)
                {
                    if (curx + n[0] >= 0 && curx + n[0] < columns && cury + n[1] >= 0 && cury + n[1] < rows)
                    {
                        if (grid[cury + n[1], curx + n[0]] == 1) continue;
                        q.Enqueue(new[] { cury + n[1], curx + n[0], curStep + 1 });

                    }
                }
            }
            return result;
        }
        // METHOD SIGNATURE ENDS
    }
}