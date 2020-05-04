public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0, r = nums.Length - 1;
        int mid = 0;
        while(l<=r){
            mid = (l+r)/2;
            //Console.WriteLine(mid);
            if(nums[mid] == target) return mid;
            if(nums[mid] < target)
                l = mid + 1;
            else
                r = mid - 1;
        }
        
        return -1;
    }
}