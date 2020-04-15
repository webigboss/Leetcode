public class Solution {
    public string OptimalDivision(int[] nums) {
        var sb = new StringBuilder();
        for(var i = 0; i < nums.Length; ++i){
            if(i != 0)
                sb.Append('/');
            if(i == 1 && nums.Length > 2)
                sb.Append('(');

            sb.Append(nums[i]);
            
            if(i == nums.Length - 1 && nums.Length > 2)
                sb.Append(')');
        }
        return sb.ToString();
    }
}