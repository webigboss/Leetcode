public class Solution {
    public int GetMoneyAmount(int n) {
        // dynamic programming (top down: recursion with memoization)
        var memo = new int[n, n];
        return GetMoneyHelper(1, n, memo);
    }
    
    private int GetMoneyHelper(int start, int end, int[,] memo){
        if(start >= end) return 0; //notice this includes equal case because when start==end, that's the case for n = 1, it's no brainer that guessing the only element will alway win and pay no money, so return 0 is correct.
        if(memo[start - 1, end - 1] > 0)
            return memo[start - 1, end - 1];
        
        var money = int.MaxValue;
        //excluding the first and the last element in the interation as it's not worthy to guess at
        for(var i = start ; i <= end; i++){
            money = Math.Min(money, i + Math.Max(GetMoneyHelper(start, i - 1, memo), GetMoneyHelper(i + 1, end, memo)));
        }
        memo[start - 1, end - 1] = money;
        return money;
    }
}