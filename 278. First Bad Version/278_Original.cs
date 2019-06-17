/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        var first = 1;
        int mid;
        if(IsBadVersion(first))
            return first;
        while(n != first){
            mid = (int)(((long)first + (long)n) / 2);
            if(IsBadVersion(mid))
                n = mid;
            else
                first = mid + 1;
        }
        
        return n;
    }
}