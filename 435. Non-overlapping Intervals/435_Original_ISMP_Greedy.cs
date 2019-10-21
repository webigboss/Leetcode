public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        //ISMP: Interval Scheduling Maximization Problem 
        //https://en.wikipedia.org/wiki/Interval_scheduling#Interval_Scheduling_Maximization
        
        if(intervals.Length == 0)
            return 0;
        var max = 1;
        
        //1. sorting the intervals by the finishing number
        Array.Sort(intervals, CompareIntervalsByFinishingNumber);
        
        //2. adding current and all other elements that intersect with current element to visited
        var end = intervals[0][1];
        for(var i = 1; i < intervals.Length; i++){
            if(intervals[i][0] >= end){
                max++;
                end = intervals[i][1];
            }
        }
        return intervals.Length - max;
    }
    
    private static int CompareIntervalsByFinishingNumber(int[] x, int[] y){
        return x[1] - y[1];
    }
    
}