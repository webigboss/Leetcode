public class Solution {
    public int MinMoves2(int[] nums) {
        //quick sort approach
        var moves = 0;
        var i = 0;
        var j = nums.Length - 1;
        Array.Sort(nums);
        while(i < j) {
            moves += nums[j--] - nums[i++];
        }
        return moves;
    }
}