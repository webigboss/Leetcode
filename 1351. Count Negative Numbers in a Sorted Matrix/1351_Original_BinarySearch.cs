public class Solution {
    public int CountNegatives(int[][] grid) {
        var iColumn = grid[0].Length;
        var nCount = 0;
        for(var y = 0; y < grid.Length; y++){
            var n = FindFirstNegativeInRow(grid[y]);
            if(n < 0) continue;
            nCount += (iColumn - n) * (grid.Length - y);
            iColumn = n;
        }
        return nCount;
    }
    
    private int FindFirstNegativeInRow(int[] a){
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