public class Solution {
    public int FindMinDifference(IList<string> timePoints) {
        var minutesList = new List<int>();
        foreach(var a in timePoints){
            var parts = a.Split(':');
            minutesList.Add(int.Parse(parts[0])*60 + int.Parse(parts[1]));
        }
        minutesList.Sort();
        minutesList.Add(minutesList[0] + 1440);
        var result = int.MaxValue;
        for(var i = 0; i < minutesList.Count - 1; ++i){
            result = Math.Min(result, minutesList[i + 1] - minutesList[i]);
        }
        return result;
    }
}