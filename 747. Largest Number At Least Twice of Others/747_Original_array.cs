public class Solution {
    public int DominantIndex(int[] nums) {
        int imax = -1, imax2 = -1, max = -1, max2 = -1;
        
        for(var i = 0; i < nums.Length; ++i){
            if(nums[i] > max){
                imax2 = imax;
                imax = i;
                max2 = max;
                max = nums[i];
            }
            else if(nums[i] < max && nums[i] > max2){
                imax2 = i;
                max2 = nums[i];
            }
        }
        if(imax == imax2 || imax2 == -1) return imax;
        return nums[imax2]*2 <= nums[imax] ? imax : -1; 
    }
}