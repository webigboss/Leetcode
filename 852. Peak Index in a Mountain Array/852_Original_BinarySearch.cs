public class Solution {
    public int PeakIndexInMountainArray(int[] A) {
        //binary search
        int lo = 1, hi = A.Length - 2, mid = 0;
        while(lo < hi){
            mid = (lo+hi)/2;
            if(A[mid]-A[mid-1]>0 && A[mid]-A[mid+1]>0) return mid;
            if(A[mid] - A[mid-1] > 0){
                lo = mid+1;
            }
            else{
                hi = mid-1;
            }
        }
        return lo;
    }
}