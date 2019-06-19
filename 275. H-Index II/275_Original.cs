public class Solution {
    public int HIndex(int[] citations) {
        if(citations.Length == 0)
            return 0;
        var hi = citations.Length - 1;
        var lo = 0;
        int mid;
        if(citations[hi] == 0)
            return 0;
        while(lo < hi){
            mid = (hi + lo) / 2;
            if(citations[mid] >= citations.Length - mid)
                hi = mid;
            else
                lo = mid + 1;
        }
        return citations.Length - lo;
    }
}