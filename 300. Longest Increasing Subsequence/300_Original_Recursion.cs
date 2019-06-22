public class Solution {
    public int LengthOfLIS(int[] nums) {
        // resursive solution with memorization
        var memo = new int[nums.Length, nums.Length];
        for(var y = 0; y < nums.Length; y++){
            for(var x = 0; x < nums.Length; x++)
                memo[x, y] = -1;
        }
        return LengthOfLISRecursive(nums, -1, 0, memo);
    }
    
    private int LengthOfLISRecursive(int[] nums, int iprev, int icur, int[,] memo){
        if(icur >= nums.Length)
            return 0;
        if(memo[iprev + 1, icur] > -1)
            return memo[iprev + 1, icur];
        
        var lengthUseCur = 0;
        var lengthUserPrev = 0;
        if(iprev < 0 || nums[icur] > nums[iprev])
            lengthUseCur = 1 + LengthOfLISRecursive(nums, icur, icur + 1, memo);
        
        var lengthUsePrev = LengthOfLISRecursive(nums, iprev, icur + 1, memo);
        var result = Math.Max(lengthUseCur, lengthUsePrev);
        memo[iprev + 1, icur] = result;
        return result;
    }
}