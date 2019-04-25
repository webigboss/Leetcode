public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length == 0)
            return 0;
        var i = 0;
        var count = 1;
        for(var j = 1; j < nums.Length; j++){
            if(nums[j] != nums[i]){
                i++;
                nums[i] = nums[j];
                count = 1;
            }
            else{
                if(count < 2){
                    count++;
                    i++;
                    nums[i] = nums[j];
                }   
            }
        }
        return i + 1;
    }
}