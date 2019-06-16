public class Solution {
    public void MoveZeroes(int[] nums) {
        var counter = 0;
        int temp;
        for(var i = 0; i < nums.Length; i++){
            if(nums[i] != 0){
                temp = nums[i];
                nums[i] = nums[counter];
                nums[counter] = temp;
                counter++;
            }
        }
    }
}