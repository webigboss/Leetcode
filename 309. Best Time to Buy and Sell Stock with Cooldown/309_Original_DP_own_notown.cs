public class Solution {
    public int MaxProfit(int[] prices) {
        //re-implement solution shared by LWCodOnO at 
        //https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-cooldown/discuss/75927/Share-my-thinking-process
        if(prices.Length == 0 || prices.Length == 1)
            return 0;
        var own = new int[prices.Length];
        var notown = new int[prices.Length];
        
        //base case
        own[0] = - prices[0];
        notown[0] = 0;
        own[1] = Math.Max(-prices[0], -prices[1]);
        notown[1] = Math.Max(0, prices[1] - prices[0]);
        
        
        for(var i = 2; i < prices.Length; i++){
            own[i] = Math.Max(own[i - 1], notown[i - 2] - prices[i]);
            notown[i] = Math.Max(notown[i - 1], own[i - 1] + prices[i]);
        }
        return Math.Max(own[prices.Length - 1], notown[prices.Length - 1]);
    }
}