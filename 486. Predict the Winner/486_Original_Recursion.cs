public class Solution {
    public bool PredictTheWinner(int[] nums) {
        return CanWin(nums, 0, nums.Length - 1, 0, 0, true);
    }
    
    private bool CanWin(int[] nums, int lo, int hi, int score1, int score2, bool isP1) {
        if(lo == hi)
            return isP1 ? score1 + nums[lo] >= score2 : score1 + nums[lo] > score2;
        return !CanWin(nums, lo + 1, hi, score2, score1 + nums[lo], !isP1) 
            || !CanWin(nums, lo, hi - 1, score2, score1 + nums[hi], !isP1);
    }
}