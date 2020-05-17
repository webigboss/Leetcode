public class Solution {
    public int BusyStudent(int[] startTime, int[] endTime, int queryTime) {
        var l = startTime.Length;
        var ans = 0;
        for(var i = 0; i < l; ++i){
            if(startTime[i] <= queryTime && endTime[i] >= queryTime)
                ans++;
        }
        
        return ans;
    }
}