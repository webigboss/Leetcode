public class Solution {
    public int HIndex(int[] citations) {
        //sorting solution
        Array.Sort(citations);
        var h = 0;
        for(var i = citations.Length - 1; i >=0; i--){
            if(citations[i] >= citations.Length - i)
                h = citations.Length - i;
        }
        return h;
    }
}