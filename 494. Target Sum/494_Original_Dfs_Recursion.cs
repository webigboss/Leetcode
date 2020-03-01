public class Solution {
    private int _count;
    public int FindTargetSumWays(int[] nums, int S) {
        if(nums.Length == 0) return 0;
        _count = 0;
        DfsHelper(nums, 0, S);
        return _count;
    }
    
    private void DfsHelper(int[] nums, int index, int remaining) {
        if(index == nums.Length){
            if(remaining == 0) _count++;
            return;
        }
        DfsHelper(nums, index + 1, remaining - nums[index]);
        DfsHelper(nums, index + 1, remaining + nums[index]);
    }
}