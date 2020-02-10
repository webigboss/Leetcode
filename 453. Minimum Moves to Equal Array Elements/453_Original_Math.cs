public class Solution {
    public int MinMoves(int[] nums) {
        //define n as the length of nums, x is the minimum moves, sum is the sum of the nums, min is the minimum element;
        //for min, it should be added by 1 in every x moves, so n = min + x;
        //after x moves: sum + x(n - 1) = n(min + x) ==> x = sum - min*x
        var sum = 0;
        var min = int.MaxValue;
        foreach(var num in nums){
            sum += num;
            min = Math.Min(min, num);
        }
        return sum - min * (nums.Length);
    }
}