public class Solution {
    public int MaxChunksToSorted(int[] arr) {
        //greedy + two pointers solution similar to 763. Partition Labels
        int l, r;
        l = r = 0;
        var ans = 0;
        while(l < arr.Length){
            ans++;
            r = arr[l];
            while(l < r){
                l++;
                r = Math.Max(r, arr[l]);
            }
            l++;
        }
        return ans;
    }
}