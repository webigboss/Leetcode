public class Solution {
    public int FindPairs(int[] nums, int k) {
        //hashtable apporach
        if(nums.Length == 0 || k < 0) return 0;
        var dict = new Dictionary<int, int>();
        foreach(var n in nums){
            if(!dict.ContainsKey(n))
                dict[n] = 1;
            else
                dict[n]++;
        }
        var result = 0;
        foreach(var kvp in dict){
            if(k == 0){ //count how many number with count >= 2
                if(kvp.Value >= 2)
                    result++;
            }
            else{ //regular case count the k gap
                if(dict.ContainsKey(kvp.Key + k))
                    result++;
            }
        }
        return result;
    }
}