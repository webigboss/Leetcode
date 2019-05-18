public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        var result = new List<string>();
        var range = "";
        var last = 0;
        if(nums.Length == 0)
            return result;
        
        for(var i = 0; i < nums.Length; i++){
            if(i == 0){
                range += nums[i].ToString();
                if(nums.Length == 1)
                    result.Add(range.ToString());
                continue;
            }
            
            if(nums[i] == nums[i - 1] + 1){
                if(i == nums.Length - 1){
                    range += "->" + nums[i].ToString();
                    result.Add(range);
                }
                continue;
            }
            else{
                if(i - 1 > last)
                    range += "->" + nums[i - 1].ToString();
                
                result.Add(range);
                range = nums[i].ToString();
                last = i;
                if(i == nums.Length - 1){
                    result.Add(range);
                }
            }      
        }
        
        return result;
    }
}