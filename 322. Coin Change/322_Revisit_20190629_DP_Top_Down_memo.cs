public class Solution {
    public int CoinChange(int[] coins, int amount) {
        //!!!!!DP top down recursion approach, I also believe the dp array is acting as a memo!!!!!!!
        var dp = new int[amount];
        //base cases
        Array.Fill(dp, amount + 1);
        var result = CoinChangeHelper(coins, dp, amount, amount);
        return result == amount + 1 ? -1 : result;
    }
    
    public int CoinChangeHelper(int[] coins, int[] dp, int amount, int curAmount){
        if(curAmount < 0)
            return amount + 1;
        if(curAmount == 0)
            return 0;
        if(dp[curAmount - 1] <= amount)
            return dp[curAmount - 1];
        for(var i = 0; i < coins.Length; i++){
            var temp = CoinChangeHelper(coins, dp, amount, curAmount - coins[i]);
            if(temp == -1) continue;
            dp[curAmount - 1] = Math.Min(dp[curAmount - 1], temp + 1);
        }
        if(dp[curAmount - 1] > amount)
            dp[curAmount - 1] = -1; // mark there is no answer for curAmount, memoize it so the calculation on every dp array element will only be done once. 
            //since it's a 1D array. if it's an 2D array like the one in burst balloon, then TC will be O(n^2), the totoal TC of this problem will be O(n*s) n: amount, s: length of coins
        return dp[curAmount - 1];
    }
}