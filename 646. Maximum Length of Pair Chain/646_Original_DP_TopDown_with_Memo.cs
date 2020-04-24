public class Solution {
    public int FindLongestChain(int[][] pairs) {
        //dp top down (recursion with memo)
        //sort by first then second element
        Array.Sort(pairs, (a,b)=>{
            if(a[0] == b[0])
                return a[1] - b[1];
            return a[0] - b[0];
        });
        
        //only need to keep one pair a at specific a[0] with the min a[1]
        var validPairs = new List<int[]>();
        var cur = int.MinValue;
        for(var i = 0; i < pairs.Length; ++i){
            if(pairs[i][0] == cur) continue;
            validPairs.Add(pairs[i]);
            cur = pairs[i][0];
        }
        
        return Helper(validPairs, 0, new int[validPairs.Count]);
    }
    
    private int Helper(List<int[]> pairs, int ifrom, int[] memo){
        if(memo[ifrom] != 0) return memo[ifrom];
        
        if(ifrom == pairs.Count - 1){
            memo[ifrom] = 1;
            return 1;
        }
        
        var result = Helper(pairs, ifrom + 1, memo);
        for(var i = ifrom + 1; i < pairs.Count; ++i){
            if(pairs[ifrom][1] < pairs[i][0])
                result = Math.Max(result, Helper(pairs, i, memo) + 1);
        }
        
        memo[ifrom] = result;
        return result;
    }
}