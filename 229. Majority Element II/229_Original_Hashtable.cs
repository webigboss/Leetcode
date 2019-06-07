public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        var result = new List<int>();
        var dict = new Dictionary<int, int>();
        
        foreach(var num in nums){
            if(!dict.ContainsKey(num))
                dict[num] = 1;
            else
                dict[num]++;
            if(dict[num] > nums.Length / 3){
                result.Add(num);
                dict[num] = 0 - nums.Length;
            }
        }
        
        return result;
    }
}