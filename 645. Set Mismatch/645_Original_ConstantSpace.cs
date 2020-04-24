public class Solution {
    public int[] FindErrorNums(int[] nums) {
        //in place swap, space complexity O(1)
        var dup = -1;
        var miss = -1;
        var i = 0;
        while(i < nums.Length){
            if(nums[i] - 1 == i || nums[nums[i] - 1] == nums[i])
                i++;
            else{
                Swap(nums, i, nums[i] - 1);
            }
        }
        
        for(var j = 0; j < nums.Length; ++j){
            if(nums[j] != j + 1){
                dup = nums[j];
                miss = j + 1;
                break;
            }
        }
        
        return new []{dup, miss};
    }
    
    private void Swap(int[] nums, int i, int j) {
        var temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}