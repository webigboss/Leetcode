public class Solution {
    public int ArrayNesting(int[] nums) {
        //brute force
        var hs = new HashSet<int>();
        var max = 0;
        for(var i = 0; i < nums.Length; ++i){
            hs.Clear();
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