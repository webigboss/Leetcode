public class Solution {
    public bool CanJump(int[] nums) {
        // greedy solution
        var i = nums.Length - 1;
        
        for(var j = nums.Length - 2; j >= 0; j--){
            if(j + nums[j] >= i)
                i = j;
        }
        
        return i == 0;
    }
}