public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        //one pass iteration, because 1<= nums[i] <= nums.Length, 
        //flip the nums[Math.Abs(nums[i])] to its negative counterpart, 
        //if it's already nagative, then it means nums[i] appears more than once
        var result = new List<int>();
        for(var i = 0; i < nums.Length; i++){
            var index = Math.Abs(nums[i]);
            if(nums[index - 1] < 0)
                result.Add(index);
            else
                nums[index - 1] *= -1;
        }
        return result;
    }
}