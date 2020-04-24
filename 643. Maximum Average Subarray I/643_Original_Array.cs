public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        double sum = 0;
        double ans = double.MinValue;
        for(var i = 0; i < nums.Length; ++i){
            sum += nums[i];
            if(i >= k - 1){
                if(i >= k)
                    sum -= nums[i - k];
                ans = Math.Max(ans, sum/k);
            }
        }
        return ans;
    }
}