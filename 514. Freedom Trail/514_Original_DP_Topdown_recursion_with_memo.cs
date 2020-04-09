public class Solution {
    public int FindRotateSteps(string ring, string key) {
        //dp top down (recursion with memoization)
        var dict = new Dictionary<char, IList<int>>();
        var memo = new int[ring.Length, key.Length];
        for(var i = 0; i < ring.Length; i++){
            if(!dict.ContainsKey(ring[i]))
                dict[ring[i]] = new List<int>();
            dict[ring[i]].Add(i);
        }
        return DpHelper(ring, 0, key, 0, dict, memo);
    }
    
    private int DpHelper(string ring, int iring, string key, int ikey, Dictionary<char, IList<int>> dict, int[,] memo){
        if(ikey == key.Length)
            return 0;
        
        if(memo[iring, ikey] > 0) 
            return memo[iring, ikey];
        
        var minSteps = int.MaxValue;
        foreach(var ito in dict[key[ikey]]){
            var curSteps = Math.Min(Math.Abs(iring - ito), ring.Length - Math.Abs(iring - ito)) + 1;
             minSteps = Math.Min(minSteps, curSteps + DpHelper(ring, ito, key, ikey + 1, dict, memo));
        }
        memo[iring, ikey] = minSteps;
        return minSteps;
    }
}