public class Solution {
    public int FindLongestChain(int[][] pairs) {
        //dp top down (recursion with memo)
        //sort by first then second element
        Array.Sort(pairs, (a,b)=>{
            if(a[0] == b[0])
                return a[1] - b[1];
            return a[0] - b[0];
        });
       
        return Helper(pairs, 0, new int[pairs.Length]);
    }
    
    private int Helper(int[][] pairs, int ifrom, int[] memo){
        if(memo[ifrom] != 0) return memo[ifrom];
        
        if(ifrom == pairs.Length - 1){
            memo[ifrom] = 1;
            return 1;
        }
        
        var result = Helper(pairs, ifrom + 1, memo);
        for(var i = ifrom + 1; i < pairs.Length; ++i){
            if(pairs[ifrom][1] < pairs[i][0])
                result = Math.Max(result, Helper(pairs, i, memo) + 1);
        }
        
        memo[ifrom] = result;
        return result;
    }
}