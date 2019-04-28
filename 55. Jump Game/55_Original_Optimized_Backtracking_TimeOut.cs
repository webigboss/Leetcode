public class Solution {
    public bool CanJump(int[] nums) {
        var canJump = false;
        CanJumpRecursive(nums, 0, ref canJump);
        return canJump;
    }
    
    private void CanJumpRecursive(int[] nums, int index, ref bool canJump){
        if(canJump)
            return;
        if(index == nums.Length - 1){
            canJump = true;
            return;
        }
        for(var i = nums[index]; i >= 1; i--){
            if(index + i <= nums.Length - 1)
                CanJumpRecursive(nums, index + i, ref canJump);
        }
    }
}