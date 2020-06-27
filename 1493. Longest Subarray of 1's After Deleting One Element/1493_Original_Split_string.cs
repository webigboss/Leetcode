public class Solution {
    public int LongestSubarray(int[] nums) {
        var s = string.Join("", nums);
        var arr = s.Split('0');
        int ans = 0;
        if(arr.Length == 1)
            return arr[0].Length-1;
        for(var i = 1; i < arr.Length; ++i){
            ans = Math.Max(ans, arr[i-1].Length + arr[i].Length);
        }
        return ans;
    }
}