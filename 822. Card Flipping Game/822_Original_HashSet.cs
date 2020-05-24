public class Solution {
    public int Flipgame(int[] fronts, int[] backs) {
        var same = new HashSet<int>();
        for(var i = 0; i < fronts.Length; ++i){
            if(fronts[i] == backs[i])
                same.Add(fronts[i]);
        }
        
        var ans = 2001;
        foreach(var n in fronts){
            if(!same.Contains(n))
                ans = Math.Min(ans, n);
        }
        foreach(var n in backs){
            if(!same.Contains(n))
                ans = Math.Min(ans, n);
        }
        return ans == 2001 ? 0: ans;
    }
}