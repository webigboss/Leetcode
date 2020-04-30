public class Solution {
    public int FindNumberOfLIS(int[] nums) {
        var n = nums.Length;
        var counts = new int[n];
        var lens = new int[n];
        Array.Fill(counts, 1);
        //not necessary but will give you the correct length, otherwise the biggest length is 1 less that the actual max length
        Array.Fill(lens, 1);
        
        for(var i=1; i<n; ++i){
            for(var j=0; j<i; ++j){
                if(nums[i] > nums[j]){
                    if(lens[i] <= lens[j]){
                        lens[i] = lens[j]+1;
                        counts[i] = counts[j];
                    }
                    else if(lens[i] == lens[j]+1){
                        counts[i] += counts[j];
                    }
                }
            }
        }
        
        var longest = 0;
        var ans = 0;
        foreach(var l in lens)
            longest = Math.Max(longest, l);
        for(var i=0; i < n; ++i){
            if(lens[i] == longest)
                ans+= counts[i];
        }
        return ans;
    }
}