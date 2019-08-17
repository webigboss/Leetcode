public class Solution {
    public int MovesToMakeZigzag(int[] nums) {
        var ansOdd = Calculate(nums, false);
        var ansEven = Calculate(nums, true);
        return Math.Min(ansOdd, ansEven);
    }
    
    private int Calculate(int[] nums, bool isEvenIndexed){
        // even indexed, means even indexed element is greater than it's neighbour, meaning odd indexed element must be smaller than it's neighbour; vice verse for odd indexed element;
        var i = 0;
        var ans = 0;
        //don't be confused, for even indexed element we will check it's odd neighbor 
        if(isEvenIndexed) i = 1;
        while(i < nums.Length){
            var curAns = 0;
            if(i > 0 && nums[i] >= nums[i - 1])
                curAns = nums[i] - nums[i - 1] + 1;
            if(i < nums.Length - 1 && nums[i] >= nums[i + 1])
                curAns = Math.Max(curAns, nums[i] - nums[i + 1] + 1);
            ans += curAns;
            i += 2;
        }
        return ans;
    }
}