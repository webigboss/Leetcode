public class Solution {
    public string Reformat(string s) {
        var nums = new List<char>();
        var alphas = new List<char>();
        
        foreach(var c in s){
            if(c - '9' > 0)
                alphas.Add(c);
            else
                nums.Add(c);
        }
        
        if(Math.Abs(alphas.Count - nums.Count) > 1)
            return string.Empty;
        var l = Math.Min(alphas.Count, nums.Count);
        var sb = new StringBuilder();
        for(var i = 0; i < l; ++i){
            if(alphas.Count >= nums.Count){
                sb.Append(alphas[i]);
                sb.Append(nums[i]);
            }
            else{
                sb.Append(nums[i]);
                sb.Append(alphas[i]);
            }
        }
        if(alphas.Count > nums.Count){
            sb.Append(alphas[alphas.Count - 1]);
        }
        if(alphas.Count < nums.Count){
            sb.Append(nums[nums.Count - 1]);
        }
        return sb.ToString();
    }
}