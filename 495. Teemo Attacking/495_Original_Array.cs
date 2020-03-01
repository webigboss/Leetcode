public class Solution {
    public int FindPoisonedDuration(int[] timeSeries, int duration) {
        var result = 0;
        
        for(var i = 0; i < timeSeries.Length; i++){
            if(i == timeSeries.Length - 1) {
                result += duration;
                continue;
            }
            if(timeSeries[i + 1] - timeSeries[i] > duration){
                result += duration;
            }
            else{
                result += timeSeries[i + 1] - timeSeries[i];
            }
        }
        return result;
    }
}