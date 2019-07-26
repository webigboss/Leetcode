public class Solution {
    public int Jump(int[] nums) {
        if(nums.Length == 0 || nums.Length == 1) return 0;
        var dp = new int[nums.Length];
        //base cases
        Array.Fill(dp, int.MaxValue);
        dp[0] = 0;
        
        for(var i = 1; i < dp.Length; i++){
            var minJump = int.MaxValue;
            for(var j = i - 1; j >= 0; j--){
                if(nums[j] >= i - j)
                    minJump = Math.Min(minJump, dp[j] + 1);
            }
            dp[i] = minJump == int.MaxValue ? 0 : minJump;
        }
        
        return dp[nums.Length - 1];
    }
}