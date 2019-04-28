public class Solution {
    public bool CanJump(int[] nums) {
        var memo = new CanJumpType[nums.Length];
        memo[memo.Length - 1] = CanJumpType.Good; 
        var maxJumpToIndex = int.MaxValue;
        for(var i = nums.Length - 2; i >= 0; i--){
            maxJumpToIndex = Math.Min(nums.Length - 1, i + nums[i]);
            for(var j = i + 1; j <= maxJumpToIndex; j++){
                if(memo[j] == CanJumpType.Good){
                    memo[i] = CanJumpType.Good;
                    break;
                }
            }
        }
        
        return memo[0] == CanJumpType.Good;
    }
}
public enum CanJumpType{
    Bad,
    Good
}