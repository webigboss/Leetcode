public class Solution {
    public int FindMinArrowShots(int[][] points) {
        if(points == null || points.Length == 0)
            return 0;
        //sort points by the ending index
        Array.Sort(points, (x, y) => x[1] - y[1]);
        var count = 1;
        var curEnding = points[0][1];
        
        for(var i = 0; i < points.Length; i++){
            if(curEnding >= points[i][0]) 
                continue;
            count++;
            curEnding = points[i][1];
        }
        return count;
    }
}