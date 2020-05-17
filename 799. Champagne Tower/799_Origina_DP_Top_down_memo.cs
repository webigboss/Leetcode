public class Solution {
    public double ChampagneTower(int poured, int query_row, int query_glass) {
        var memo = new double[100][];
        for(var i = 0; i < 100; ++i){
            memo[i] = new double[100];
            Array.Fill(memo[i], -1);
        }
        var ans = Helper(poured, query_row, query_glass, memo);
        return Math.Min(1, ans);
    }
    
    double Helper(int poured, int row, int glass, double[][] memo){
        if(glass < 0 || glass > row) return 0;
        if(memo[row][glass] > -1) {
            //Console.WriteLine($"ReturnFromMemo, row:{row} glass:{glass}, ret: {memo[row, glass]}");
            return memo[row][glass];
        }

        if(row == 0) {
            memo[row][glass] = poured;
            //Console.WriteLine($"Return, row:{row} glass:{glass}, ret: {memo[row][glass]}");
            return poured;
        }
        
        var l = Helper(poured, row-1, glass, memo);
        var r = Helper(poured, row-1, glass-1, memo);
        var ret = Math.Max((l-1)/2, 0) + Math.Max((r-1)/2,0);
        memo[row][glass] = ret;
        //Console.WriteLine($"Return, row:{row} glass:{glass}, ret: {memo[row][glass]}");
        return ret;
    }
}