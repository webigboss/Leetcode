public class Solution {
    public IList<int> TopKFrequent(int[] nums, int k) {
        var result = new List<int>();
        var dict = new Dictionary<int, int>();
        //there is no native priorityQueue class in C#, so I just use the Array.Sort<T>(Array, Comparison<T>)
        //1. build dictionary O(n)
        for(var i = 0; i < nums.Length; i++){
            if(dict.ContainsKey(nums[i]))
                dict[nums[i]]++;
            else
                dict[nums[i]] = 1;
        }
        
        //2. Sort the array by dict value count: O(nlog(n))
        Array.Sort(nums, (a, b) => dict[a] - dict[b]);
        
        //3. find the first K element from the end to the start: O(n)
        var counter = 1;
        var hs = new HashSet<int>();
        result.Add(nums[nums.Length - 1]);
        hs.Add(nums[nums.Length - 1]);
        for(var i = nums.Length - 2; i >= 0; i--){
            if(counter == k)
                break;
            if(nums[i] != nums[i + 1] && !hs.Contains(nums[i])){
                result.Add(nums[i]);
                hs.Add(nums[i]);
                counter++;
            }
        }
        return result;
    }
}