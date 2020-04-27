public class Solution {
    public int[] FindDiagonalOrder(IList<IList<int>> nums) {
        var dict = new Dictionary<int, List<int>>();
        var maxCol = 0;
        for(var i = 0; i < nums.Count; ++i){
            maxCol = Math.Max(maxCol, nums[i].Count);
            for(var j = 0; j < nums[i].Count; ++j){
                if(!dict.ContainsKey(i+j))
                    dict[i+j] = new List<int>();
                dict[i+j].Add(nums[i][j]);
            }
        }
        var maxIndexSum = nums.Count + maxCol - 1;
        var ans = new List<int>();
        for(var i = 0; i < maxIndexSum; ++i){
            if(dict.ContainsKey(i)){
                //add to ans reversely
                for(var j = dict[i].Count - 1; j >= 0; --j){
                    ans.Add(dict[i][j]);
                }
            }
        }
        
        return ans.ToArray();
    }
}