public class Solution {
    public bool StoneGame(int[] piles) {
        
        //memo[i][j] max score Alex could get from i to j;
        var memo = new int[piles.Length][];
        for(var i = 0; i < memo.Length; ++i){
            memo[i] = new int[piles.Length];
            Array.Fill(memo[i], int.MinValue);
        }
        var ans = Helper(piles, 0, piles.Length-1, true, memo);
        return ans > 0;
    }
    
    int Helper(int[] piles, int l, int r, bool isAlex, int[][] memo) {
        if(memo[l][r] != int.MinValue) return memo[l][r];
                
        var ans = 0;
        if(l == r){
            if(isAlex) ans = piles[l];
            else ans = -piles[l];
        }
        else{
            var left = Helper(piles, l+1, r, !isAlex, memo);
            var right = Helper(piles, l, r-1, !isAlex, memo);
            if(isAlex)
                ans = Math.Max(left + piles[l], right + piles[r]);
            else 
                ans = Math.Min(left - piles[l], right - piles[r]);
        }
        memo[l][r] = ans;
        return ans;
    }
}