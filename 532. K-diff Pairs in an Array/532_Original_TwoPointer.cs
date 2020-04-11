public class Solution {
    public int FindPairs(int[] nums, int k) {
        //sort and 2 pointers
        if(nums.Length < 2) return 0;
        Array.Sort(nums);
        var lo = 0;
        var hi = 1;
        var result = 0;
        while(true){
            if(hi == nums.Length)
                break;

            if(nums[hi] - nums[lo] == k){
                //dedup logic, only need to check hi, lo won't get a change to produce duplicate answer 
                //because we keep advanding hi when nums[hi]-nums[lo] == k
                //hi==lo+1 check is to make sure we don't take lo into account, it's useful especially for k = 0
                if(nums[hi] > nums[hi - 1] || hi == lo + 1) result++;
                hi++;
            }
            else if(nums[hi] - nums[lo] < k){
                hi++;
            }
            else
                lo++;
            //special case
            if(lo == hi)
                hi++;
        }
        return result;
    }
}