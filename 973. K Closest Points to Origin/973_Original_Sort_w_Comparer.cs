public class Solution {
    public int[][] KClosest(int[][] points, int K) {
        //sort approach using Comparer delegate
        Array.Sort(points, (a, b) => 
             a[0]*a[0] + a[1]*a[1] - b[0]*b[0] - b[1]*b[1]
        );
        
        var result = new int[K][];
        for(var i = 0; i < K; ++i){
            result[i] = points[i];
        }
        return result;
    }
}