public class Solution {
    public int[] FindDiagonalOrder(IList<IList<int>> nums) {
        var ans = new List<int>();
        var maxCol = 0;
        var curRow = 0;
        var r = 0;
        var c = 0;
        foreach(var n in nums)
            maxCol = Math.Max(maxCol, n.Count);
        var maxRow = nums.Count + maxCol - 1;
        
        while(curRow < maxRow){
            if(r > nums.Count - 1){
                c += r - nums.Count + 1;
                r = nums.Count - 1;                
            }
            if(r <= nums.Count - 1 && c <= nums[r].Count - 1)
                ans.Add(nums[r][c]);
            r--;
            c++;
            if(r == -1){
                r = ++curRow;
                c = 0;

            }
        }
        return ans.ToArray();
        
    }
}