public class Solution {
    public int KthSmallest(int[][] matrix, int k) {
        var comparer = new AllowDuplicateComparer<int>();
        var sortedList = new SortedList<int, int[]>(comparer);
        
        for(var y = 0; y < matrix.Length; y++)
            sortedList.Add(matrix[y][0], new int[]{y, 0});
        
        var count = 0;
        var result = 0;
        while(count < k){
            result = sortedList.Keys[0];
            var yIndex = sortedList.Values[0][0];
            var xIndex = sortedList.Values[0][1];
            sortedList.RemoveAt(0);
            if(xIndex < matrix[0].Length - 1)
                sortedList.Add(matrix[yIndex][xIndex + 1], new int[]{yIndex, xIndex + 1});
            count++;
        }
        return result;
    }
    
    public class AllowDuplicateComparer<T>: IComparer<T>{
        public int Compare(T a, T b){
            if(a is int){
                if(Convert.ToInt32(a) <= Convert.ToInt32(b)) return -1;
                else return 1;
            }
            else return 0;
        }
    }
}