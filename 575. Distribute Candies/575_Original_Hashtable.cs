public class Solution {
    public int DistributeCandies(int[] candies) {
        var hs = new HashSet<int>();
        for(var i = 0; i < candies.Length; ++i){
            if(!hs.Contains(candies[i]))
                hs.Add(candies[i]);
            if(hs.Count >= candies.Length/2)
                return candies.Length / 2;
        }
        return hs.Count;
    }
}