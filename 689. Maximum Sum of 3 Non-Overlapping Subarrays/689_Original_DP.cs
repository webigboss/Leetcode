public class Solution {
    public int[] MaxSumOfThreeSubarrays(int[] nums, int k) {
        var n = nums.Length;
        int[] sums = new int[n+1], posLeft = new int[n], posRight = new int[n];
        
        for(var i = 0; i < n; ++i)
            sums[i+1] = sums[i] + nums[i];
        
        //starting index of subarray with length = k and ends with i
        var curSum = sums[k] - sums[0];
        for(var i = k; i < n; ++i){ 
            if(sums[i+1]-sums[i+1-k] > curSum){
                posLeft[i] = i+1-k;
                curSum = sums[i+1]-sums[i+1-k];
            }
            else
                posLeft[i] = posLeft[i-1];
        }
        
        //starting index of subarray with length = k and starts with i
        posRight[n-k] = n-k;
        curSum = sums[n] - sums[n-k];
        for(var i = n-k-1; i >=0; --i){
            if(sums[i+k] - sums[i] >= curSum){
                posRight[i] = i;
                curSum = sums[i+k] - sums[i];
            }
            else
                posRight[i] = posRight[i+1];
            
        }
        
        var ans = new int[3];
        var max = 0;
        // check all possible middle substring. with middle substring's starting index i
        for(var i = k; i <= n-k*2; ++i){
            var l = posLeft[i-1];
            var r = posRight[i+k];
            var total = (sums[l+k]-sums[l])+(sums[i+k]-sums[i])+(sums[r+k]-sums[r]);
            if(total > max){
                max = total;
                ans[0] = l;
                ans[1] = i;
                ans[2] = r;
            }
        }
        return ans;
    }
}