public class Solution {
    private int mod = (int)(1e9+7);
    public int NumberWays(IList<IList<int>> hats) {
        var htp = new List<int>[41];
        for(var i = 0; i<htp.Length; ++i)
            htp[i] = new List<int>();
        var pplcnt = hats.Count;
        for(var i =0; i < hats.Count; ++i){
            foreach(var h in hats[i])
                htp[h].Add(i);
        }
        //Console.WriteLine($"mAll: {(1<<pplcnt)-1}");
        return Helper(htp, 1, (1<<pplcnt)-1, 0, new int[41, 512]);
    }
    
    private int Helper(List<int>[] htp, int ihat, int mAll, int mUsed, int[,] memo){
        //Console.WriteLine($"ihat: {ihat}, mUsed: {mUsed}");
        if(mUsed == mAll) return 1;   
        if(ihat > 40) return 0; 
        if(memo[ihat, mUsed] > 0)
            return memo[ihat, mUsed];
      
        //for hats that no people prefer
        var ans = Helper(htp, ihat+1, mAll, mUsed, memo);  
        //Console.WriteLine($"ihat:{ihat}");
        for(var i =0; i < htp[ihat].Count; ++i){
            var ppl = htp[ihat][i];
            if(((mUsed>>ppl) & 1) == 1) continue;
            ans += Helper(htp, ihat+1, mAll, mUsed|(1<<ppl), memo);
            ans %= mod;
        }
        memo[ihat, mUsed] = ans;
        return ans;
    }
}
