public class Solution {
    public int FindRadius(int[] houses, int[] heaters) {
        //binary search approach
        Array.Sort(heaters);
        var maxRadius = int.MinValue;
        for(var i = 0; i < houses.Length; i++){
            maxRadius = Math.Max(maxRadius, findMinDistance(houses[i], heaters));
        }
        return maxRadius;
    }
    
    private int findMinDistance(int i, int[] heaters){
        int lo = 0;
        int hi = heaters.Length - 1;
        int mid = 0;
        while(lo + 1 < hi){
            mid = (lo + hi) / 2;
            if(heaters[mid] == i) return 0;
            if(heaters[mid] > i)
                hi = mid;
            else
                lo = mid;
        }
        return Math.Min(Math.Abs(i - heaters[lo]), Math.Abs(i - heaters[hi]));
    }
}