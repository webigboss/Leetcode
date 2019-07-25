public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        var intervalsList = new List<int[]>();
        var overlappings = new List<int[]>();
        var startingIndex = -1;
        for(var i = 0; i < intervals.Length; i++){
            var maxLeft = Math.Max(intervals[i][0], newInterval[0]);
            var minRight = Math.Min(intervals[i][1], newInterval[1]);
            if(maxLeft <= minRight){ // has overlapping
                if(startingIndex == -1) startingIndex = i;
                overlappings.Add(intervals[i]);
            }
            else{ // maxleft > minRight, no overlapping
                if(overlappings.Count == 0 && newInterval[0] > intervals[i][1]) {
                    startingIndex = i + 1;
                }
                intervalsList.Add(intervals[i]);
            }
        }
        if(startingIndex == -1){
            intervalsList.Insert(0, newInterval);
            return intervalsList.ToArray();
        }
        else if(startingIndex == intervals.Length){
            intervalsList.Add(newInterval);
            return intervalsList.ToArray();
        }

        for(var i = 0; i < overlappings.Count; i++){
            newInterval[0] = Math.Min(newInterval[0], overlappings[i][0]);
            newInterval[1] = Math.Max(newInterval[1], overlappings[i][1]);
        }
        intervalsList.Insert(startingIndex, newInterval);
        return intervalsList.ToArray();
    }
}