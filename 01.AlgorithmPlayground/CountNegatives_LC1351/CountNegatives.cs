namespace AlgorithmPlayground
{
    public class CountNegatives
    {
        public CountNegatives()
        {
            var a = new[] { -1, -1, -1, -2, -3, -4, -5, -6, -7 };
            var grid = new[]{
                new []{4,3,2,-1},
                new []{3,2,1,-1},
                new []{1,1,-1,-2},
                new []{-1,-1,-2,-3}
            };
            var i = CountNegativesSolution(grid);
        }

        public int CountNegativesSolution(int[][] grid)
        {
            var iColumn = grid[0].Length;
            var nCount = 0;
            for (var y = 0; y < grid.Length; y++)
            {
                var n = FindFirstNegativeInRow(grid[y]);
                if (n < 0) continue;
                nCount += (iColumn - n) * (grid.Length - y);
                iColumn = n;
            }
            return nCount;
        }

        public int FindFirstNegativeInRow(int[] a)
        {
            int mid;
            int lo = 0;
            int hi = a.Length - 1;
            while (lo + 1 < hi)
            {
                mid = (lo + hi) / 2;
                if (a[mid] >= 0)
                    lo = mid;
                else
                    hi = mid;
            }

            if (a[lo] >= 0 && a[hi] < 0)
                return hi;
            else if (a[lo] < 0)
                return lo;
            else return -1;
        }
    }
}