public class Solution {
    public int[] ShortestToChar(string S, char C) {
        var indexes = new List<int>();
        for(var i = 0; i<S.Length; ++i){
            if(S[i] == C)
                indexes.Add(i);
        }
        
        var ans = new int[S.Length];
        var j = 0;
        for(var i = 0; i < S.Length; ++i){
            while(j < indexes.Count - 1 && indexes[j] < i)
                  j++;
            ans[i] = Math.Abs(indexes[j]-i);
            if(j > 0)
                ans[i] = Math.Min(ans[i], Math.Abs(i-indexes[j-1]));
        }
        return ans; 
    }
}