public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        var count = 0;
        var maxCount = 0;
        foreach(var n in nums){
            if(n == 1) count++;
            else {
                maxCount = Math.Max(maxCount, count);
                count = 0;
            }
        }
        maxCount = Math.Max(maxCount, count);
        return maxCount;
    }
}