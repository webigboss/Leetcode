public class Solution {
    public int FindRotateSteps(string ring, string key) {
        //dp bottom up
        var dict = new Dictionary<char, IList<int>>();
        //dp[i, j]: when current 12:00 points to ring[i], the key is from j to key.Length, the minimum steps;
        var dp = new int[ring.Length, key.Length + 1];
        //base case is dp[i, key.Length] = 0, no need to initialize as default value is 0;
        
        for(var i = 0; i < ring.Length; i++){
            if(!dict.ContainsKey(ring[i]))
                dict[ring[i]] = new List<int>();
            dict[ring[i]].Add(i);
        }
        
        for(var j = key.Length - 1; j >= 0; --j){
            for(var i = 0; i < ring.Length; ++i){
                var minSteps = int.MaxValue;
                foreach(var iTo in dict[key[j]]){
                    var curSteps = Math.Min(Math.Abs(i - iTo), ring.Length - Math.Abs(i - iTo)) + 1; 
                    minSteps = Math.Min(minSteps, curSteps + dp[iTo, j + 1]);
                }
                dp[i, j] = minSteps;
            }
        }
        return dp[0, 0];
    }
}