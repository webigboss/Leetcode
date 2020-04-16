public class Solution {
    public int[][] MatrixReshape(int[][] nums, int r, int c) {
        if(nums.Length == 0 || nums[0].Length == 0) 
            return nums;
        var size = nums.Length * nums[0].Length;
        if(size != r*c || nums.Length == r && nums[0].Length == c)
            return nums;
        var result = new int[r][];
        
        var count = 0;
        for(var i = 0; i < nums.Length; ++i){
            for(var j = 0; j <nums[0].Length; ++j){
                if(count % c == 0)
                    result[count / c] = new int[c];
                result[count / c][count % c] = nums[i][j];
                count++;
            }
        }
        return result;
    }
}