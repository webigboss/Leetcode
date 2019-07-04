public class NumArray {

    private int[] _sum;
    private int[] _nums;
    public NumArray(int[] nums) {
        _sum = new int[nums.Length];
        _nums = nums;
        var tempsum = 0;
        for(var i = 0; i < _nums.Length; i++){
            tempsum += _nums[i];
            _sum[i] = tempsum;
        }
    }
    
    public void Update(int i, int val) {
        var diff = val - _nums[i];
        for(var j = i; j < _sum.Length; j++){
            _sum[j] += diff;
        }
        _nums[i] = val;
    }
    
    public int SumRange(int i, int j) {
        if(i == 0)
            return _sum[j];    
        return _sum[j] - _sum[i - 1];
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * obj.Update(i,val);
 * int param_2 = obj.SumRange(i,j);
 */