public class Solution {
    public void NextPermutation(int[] nums) {
        //the index for the first element that is smaller than it's predecessor from the right;
        var index1 = -1;
        //the index for the element to be replaced by index1, that is starting from index1 the smallest element that is bigger than the value at index 1 
        var index2 = -1;
        
        for(var i = nums.Length - 1; i > 0; i--){
            if(nums[i - 1] >= nums[i])
                continue;
            else{
                index1 = i - 1;
                break;
            }
        }
        
        if(index1 == -1){
            Array.Sort(nums); // 	No need to use Array.Sort, because it is really a reverse of all the elements is needed. 
            return;
        }
        
        var min = nums[index1 + 1];
        var temp = 0;
        for(var i = index1 + 1; i <= nums.Length - 1; i++){
            if(nums[i] > nums[index1] && nums[i] <= min){
                index2 = i;
            }
        }
        temp = nums[index1];
        nums[index1] = nums[index2];
        nums[index2] = temp;
        
        Array.Sort(nums, index1 + 1, nums.Length - 1 - index1); //	No need to use Array.Sort, because it is really a reverse of all the elements is needed. 
    }
}