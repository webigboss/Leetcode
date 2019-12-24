public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        //trivial solution with linear spece complexity O(n) using additional int array(simplified hashtable)
        //two pass so time complexity is O(1)
        var visited = new int[nums.Length];
        var result = new List<int>();
        
        for(var i = 0; i < nums.Length; i++)
            visited[nums[i] - 1]++;
        
        
        for(var i = 0; i < nums.Length; i++)
            if(visited[i] == 0) result.Add(i + 1);
        
        return result;
    }
}