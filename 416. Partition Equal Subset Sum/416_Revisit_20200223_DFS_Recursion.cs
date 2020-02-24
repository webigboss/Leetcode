public class Solution {
    public bool CanPartition(int[] nums) {
        //same as 473, 698
        int sum = 0;
        foreach(var n in nums)
            sum += n;
        if(sum % 2 != 0) return false;
        Array.Sort(nums, (a, b) => b - a);
        return DfsHelper(nums, 0, 0, 0, sum / 2);
    }
    
    private bool DfsHelper(int[] nums, int i, int sumL, int sumR, int target){
        if(i == nums.Length){
            if(sumL == sumR) return true;
            else return false;
        }
        
        return sumL + nums[i] <= target && DfsHelper(nums, i + 1, sumL + nums[i], sumR, target) 
            || sumR + nums[i] <= target && DfsHelper(nums, i + 1, sumL, sumR + nums[i], target);
    } 
}