public class Solution {
    public int MaxProduct(int[] nums) {
        int m1 = 0, m2 = 0;
        for(var i = 0; i < nums.Length; ++i){
            if(nums[i] > m1){
                m2 = m1;
                m1 = nums[i];
            }
            else if(nums[i] > m2){
                m2 = nums[i];
            }
        }
        return (m1-1)*(m2-1);
    }
}