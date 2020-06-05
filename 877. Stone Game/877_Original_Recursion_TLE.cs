public class Solution {
    public bool StoneGame(int[] piles) {
        // var memo = new int[piles.Length][];
        // for(var i = 0; i < memo.Length; ++i)
        //     memo[i] = new int[piles.Length];
        return Helper(piles, 0, piles.Length-1, 0, 0);
    }
    
    bool Helper(int[] piles, int l, int r, int score1, int score2) {
        // Console.WriteLine($"Enter: l:{l}, r:{r}, score1:{score1}, score2:{score2}");
    
        var ans = false;
        if(l == r){
            ans = score1 + piles[l] > score2;
            // Console.WriteLine($"Exit: l:{l}, r:{r}, score1:{score1}, score2:{score2}, ans:{ans}");
            // memo[l][r] = ans ? 1 : -1;
            return ans;
        }

        var takeL = Helper(piles, l+1, r, score2, score1 + piles[l]);
        var takeR = Helper(piles, l, r-1, score2, score1 + piles[r]);
        ans = !takeL || !takeR;

        // Console.WriteLine($"Exit: l:{l}, r:{r}, score1:{score1}, score2:{score2}, ans:{ans}");
        return ans;
    }
}