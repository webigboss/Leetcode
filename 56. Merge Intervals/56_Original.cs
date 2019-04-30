public class Solution {
    public int[][] Merge(int[][] intervals) {
        //sort by the starting number, and then the merge will be easy
        //e.g. [[1,3],[5,8],[8,10],[15,18],[2,6]] == sort ==> [[1,3],[2,6],[5,8],[8,10],[15,18]]
        // compare the first interval's last number with second's first number, if lastNumber >= firstNumber, then merge the 2
        
        //Bubble sort solution
        if(intervals.Length == 0 || intervals.Length == 1)
            return intervals;
        var swap = false;
        var temp = new int[2];
        var i = 1;
        var j = 0;
        while(true){
            if(intervals[i - 1][0] > intervals[i][0]){
                temp = intervals[i - 1];
                intervals[i - 1] = intervals[i];
                intervals[i] = temp;
                swap = true;
            }
            if(i == intervals.Length - 1){
                i = 1;
                if(swap == true)
                    swap = false;
                else 
                    break;
                continue;
            }
            i++;
        }
        
        i = 0;
        while(i <= intervals.Length - 2){
            if(Math.Max(intervals[i][1], intervals[j][1]) >= intervals[i + 1][0]){
                intervals[j][1] = Math.Max(intervals[j][1], intervals[i + 1][1]); 
            }
            else{
                intervals[++j] = intervals[i + 1];
            }
            i++;
        }
        
        Array.Resize(ref intervals, j + 1);
        return intervals;
    }
}