public class NumArray {
    //dp solution
    private int[] _sum;
    public NumArray(int[] nums) {
        _sum = new int[nums.Length + 1];
        for(var i = 0; i < nums.Length; i++)
            _sum[i + 1] = _sum[i] + nums[i];
    }
    
    public int SumRange(int i, int j) {
        return _sum[j + 1] - _sum[i];
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(i,j);
 */