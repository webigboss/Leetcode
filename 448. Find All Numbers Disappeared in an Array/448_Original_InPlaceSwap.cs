public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        //iteration numbers in num and keep swapping the nums[i] with nums[nums[i] - 1] if: nums[i] !=  i + 1
        var result = new List<int>();
        for(var i = 0; i < nums.Length; i++){
            while(nums[i] != i + 1 && nums[i] != nums[nums[i] - 1]){
                Swap(nums, i, nums[i] - 1);
            }
        }
        
        for(var i = 0; i < nums.Length; i++){
            if(nums[i] != i + 1) result.Add(i + 1);
        }
        
        return result;
    }
    
    private void Swap(int[] nums, int i, int j){
        var temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}