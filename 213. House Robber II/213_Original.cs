public class Solution {
    public int Rob(int[] nums) {
        if(nums.Length == 0)
            return 0;
        if(nums.Length == 1)
            return nums[0];
        if(nums.Length == 2)
            return Math.Max(nums[0], nums[1]);
        //dp1 for the pass with houses 0 ~ nums.Length - 2; dp2 for the pass with houses 1 ~ nums.Length - 1
        var dp1 = new int[nums.Length];
        var dp2 = new int[nums.Length];
        
        //base cases
        dp1[1] = nums[0];
        dp2[1] = nums[1];
        
        //pass 0 ~ nums.Length - 2
        //pass 1 ~ nums.Length - 1
        for(var i = 2; i < nums.Length; i++){
            dp1[i] = Math.Max(dp1[i - 1], dp1[i - 2] + nums[i - 1]);
            dp2[i] = Math.Max(dp2[i - 1], dp2[i - 2] + nums[i]);
        }
        
        return Math.Max(dp1[nums.Length - 1], dp2[nums.Length - 1]);
    }
}