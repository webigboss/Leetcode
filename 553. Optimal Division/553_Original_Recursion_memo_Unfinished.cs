public class Solution {
    public string OptimalDivision(int[] nums) {
        _max = 0;
        _result = string.Empty;
        
        Helper(nums, 0, nums.Length - 1, new Dictionary<string, int>());

        return _result;
    }
    
    private int Helper(List<int> nums, int lo, int hi, Dictionary<string, int> memo){
        if(memo.ContainsKey(formula))
            return;
        
        if(nums.Length == 1) {
            memo[formula] = nums[0];
            if(nums[0] > _max){
                _max = nums[0];
                _result = formula;
            }
        }
        var result = 0;
        var formula = GetFormula(nums, lo, hi);
        var nums_new = new List<int>();
        var div = nums[i];
        for(var k = i + 1; k <= j; ++k)
            div /= nums[k];
        if(i > 0)
            nums_new.AddRange(nums.GetRange(0, i));
        nums_new.Add(div);
        if(j < nums.Length - 1)
            new_new.AddRange(nums.GetRange(j + 1, nums.Length - 1));

        for(var i = 0; i < nums_new.Length - 1; ++i){
            for(var j = i + 1; j < nums_new.Length; ++j){
                result = Math.Max(result, Helper(nums_new, i, j, memo));
            }
        }

    }
    
    //sample 1000/(100/10/2) => 1000/100/10/2|1|3
    private string GetFormula(int[] nums, int lo, int hi){
        var sb = new StringBuilder();
        for(var i = 0; i < nums.Length; ++i){
            if(i != 1) sb.Append('/');
            sb.Append(nums[i]);
        }
        sb.Append('|');
        sb.Append(lo);
        sb.Append('|');
        sb.Append(hi);
        return sb.ToString();
    }
}