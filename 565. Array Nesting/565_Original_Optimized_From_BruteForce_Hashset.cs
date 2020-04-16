public class Solution {
    public int ArrayNesting(int[] nums) {
        //optimized from brute force, the idea of optimization is
        //the chain of selection is in fact an circle, so no matter from which element
        //the final answer will always be the same, so we only need to go through the circle onece
        //use the hs to record the visited, but without clear in the brute force appraoch
        //thus we can avoid step into cirles again
        var hs = new HashSet<int>();
        var max = 0;
        for(var i = 0; i < nums.Length; ++i){
            // hs.Clear(); only difference from the brute force approach is comment out this line 
            var j = i;
            var l = 0;
            while(!hs.Contains(j)){
                hs.Add(j);
                j = nums[j];
                l++;
            }
            max = Math.Max(max, l);
        }
        return max;
    }
}