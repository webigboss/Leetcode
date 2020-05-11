public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int max = 0;
        foreach(var c in candies)
            max = Math.Max(max, c);
        
        var ans = new List<bool>();
        foreach(var c in candies){
            if(c + extraCandies >= max)
                ans.Add(true);
            else
                ans.Add(false);
        }
        return ans;
    }
}