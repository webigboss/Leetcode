public class Solution {
    public int MaxCoins(int[] nums) {
        // !!!!!!!!!!!!Divide and conquor with memoizatoin, I also believe this is DP top down approach (recursion), it should be correct!!!!!!!!!!!!!!!
        //https://stackoverflow.com/questions/6184869/what-is-the-difference-between-memoization-and-dynamic-programming
        //1. burst all balloons with 0 point
        var numsNew = new int[nums.Length + 2];
        numsNew[0] = 1;
        var index = 1;
        foreach(var num in nums)
            if(num != 0) numsNew[index++] = num; 
        numsNew[index] = 1;
        //2. create a 2D array memo[ileft,iright] to memorize the maximum coins we could get when from the boundary from ileft to iright
        var memo = new int[index + 1, index + 1];
        //base cases
        memo[0,0] = 1;
        memo[index, index] = 1;
        for(var i = 1; i < index; i++)
            memo[i, i] = numsNew[i - 1] * numsNew[i] * numsNew[i + 1];
        
        return MaxCoinsHelper(numsNew, 1, index - 1, memo);
    }
    
    private int MaxCoinsHelper(int[] nums, int ileft, int iright, int[,] memo){
        if(ileft > iright) return 0;
        if(memo[ileft, iright] != 0) return memo[ileft, iright];
        var result = int.MinValue;
        for(var i = ileft; i <= iright; i++){
            result = Math.Max(result, MaxCoinsHelper(nums, ileft, i - 1, memo) 
                              + nums[ileft - 1] * nums[i] * nums[iright + 1] // !!!!!! important point that easy to be mistaken: for the whole range, it's nums[1]*nums[i]*nums[nums.Length - 1] = nums[i], but not for sub ranges. 
                              + MaxCoinsHelper(nums, i + 1, iright, memo));
        }
        memo[ileft, iright] = result;
        return result;
    }
}