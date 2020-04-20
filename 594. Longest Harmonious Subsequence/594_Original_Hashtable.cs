public class Solution {
    public int FindLHS(int[] nums) {
        var dict = new Dictionary<int, int>();
        for(var i = 0; i < nums.Length; ++i){
            if(!dict.ContainsKey(nums[i]))
                dict[nums[i]] = 1;
            else
                dict[nums[i]]++;
        }
        var result = 0;
        foreach(var kvp in dict){
            var k = kvp.Key;
            var v = kvp.Value;
            var cur = 0;
            if(dict.ContainsKey(k-1))
                cur = v + dict[k-1];
            if(dict.ContainsKey(k+1))
                cur = Math.Max(cur, v + dict[k+1]);
            result = Math.Max(result, cur);
        }   
        return result;
    }
}