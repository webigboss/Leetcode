public class Solution {
    public int MaxEvents(int[][] events) {
        //sort intervals by starting index descending then by ending index ascending
        Array.Sort(events, (a, b) => {
            if(a[0] < b[0])
                return 1;
            else if(a[0] > b[0])
                return -1;
            else{
                if(a[1] > b[1])
                    return 1;
                else if(a[1] < b[1])
                    return -1;
                else return 0;
            }
        });
        
        var count = 0;
        var attended = new HashSet<int>();
        for(var i = 0; i < events.Length; i++){
            //try from the ending day to the starting day
            for(var j = events[i][1]; j >= events[i][0]; j--){
                if(!attended.Contains(j)){
                    attended.Add(j);
                    count++;
                    break;
                }
            }
        }
        return count;
    }
}