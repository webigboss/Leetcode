public class Solution {
    public IList<int> FindClosestElements(int[] arr, int k, int x) {
        //binary search find the most closed item and use it as the center to expand
        int lo, hi;
        lo = 0; hi = arr.Length - 1;
        var mid = 0;
        while(lo < hi - 1){
            mid = (lo + hi) / 2;
            if(arr[mid] >= x){
                hi = mid;
            }
            else{
                lo = mid;
            }
        }
        var c = Math.Abs(arr[lo] - x) < Math.Abs(arr[hi] - x) ? lo : hi;

        lo = c - 1;
        hi = c + 1;
        k--;
        var ans = new List<int>();
        ans.Add(arr[c]);
        while(k > 0){
            if(lo < 0){
                ans.Add(arr[hi++]);
                k--;
                continue;
            }
            if(hi > arr.Length - 1){
                ans.Add(arr[lo--]);
                k--;
                continue;
            }
            
            if(Math.Abs(arr[lo] - x) <= Math.Abs(arr[hi] - x)){
                ans.Add(arr[lo--]);
            }
            else{
                ans.Add(arr[hi++]);
            }
            k--;
        }
        ans.Sort();
        return ans;
    }
}