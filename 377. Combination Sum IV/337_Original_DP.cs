public class Solution {
    public int CombinationSum4(int[] nums, int target) {
        //DP solution

        /*!!!!Note: try to deduce the dp formula by using nums=1,2,3; target = 5; 
          At first I did came up with this formula then I questioned about how it work with the the requirement 
          "different sequences are counted as different combinations", this is infact permutations
          then I cannot figure out things like how 1121, 1211, 1112, 2111 would be fullfilled by the formula.

          the correct thinking is, in the formula, every dp[i - num[j]] can be consider as appending nums[j] to every combination of dp[i - num[j]].
          so to figure out the above problem of 1121,1211,1112,2111: 1121,1211,2111 are actually from dp[4]: 112,121,211 by appending 1 to the last,
          and 1112 is 111 from dp[3], so we can be sure that no combination(permutation in fact) will be missed   
        */
        var dp = new int[target + 1];
        int result;
        //base case
        dp[0] = 1;  // e.g. image nums= [1,2,3], dp[1] = dp[0] + dp[-1] + dp[-2] = dp[0]; so dp[0] has to be 1;
        
        for(var i = 1; i <= target; i++){
            result = 0;
            for(var j = 0; j < nums.Length; j++){
                if(i >= nums[j])
                    result += dp[i - nums[j]];
            }
            dp[i] = result;
        }
        
        return dp[target];
    }
}