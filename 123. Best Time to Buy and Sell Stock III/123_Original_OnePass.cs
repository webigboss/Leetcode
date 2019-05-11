public class Solution {
    public int MaxProfit(int[] prices) {
    //https://leetcode.com/problems/best-time-to-buy-and-sell-stock-iii/discuss/39611/Is-it-Best-Solution-with-O(n)-O(1).
    // the max profit is (4 - 1) + (3 - 0), which is also equal to 4 - (1 - (3 - 0))
    // '0' is the min of cost1, (3 - 0) is the profit1, (1 - (3 - 0)) is the cost2, and 4 - (1 - (3 - 0)) is the profit2
    // this also works for the increasing sequence, say, 1,2,3,4, the max profit is 4 - (4 - (4 - 1))
    // in order to get the max profit eventually, profit1 must be as relatively most as possible to produce a small cost2, and therefore cost2 can be as less as possible to give us the final max profit2. So now we understand why and where we need to take min or max of all cost and profit variables.....
    // Here is my code rewritten based on @SmileChen 's previous post:

        if(prices.Length == 0 || prices == null)
            return 0;
        var cost1 = int.MaxValue;
        var cost2 = int.MaxValue;
        var profit1 = 0;
        var profit2 = 0;
        
        foreach(int price in prices){
            cost1 = Math.Min(cost1, price);
            profit1 = Math.Max(profit1, price - cost1);
            cost2 = Math.Min(cost2, price - profit1);
            profit2 = Math.Max(profit2, price - cost2);
        }
        
        return profit2;
    }
}