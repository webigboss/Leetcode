public class Solution {
    public int MaxDotProduct(int[] nums1, int[] nums2) {
        //dp bottom up
        int l1 = nums1.Length, l2 = nums2.Length;
        
        var dp = new int[l1+1][];
        for(var i = 0; i <= l1; ++i){
            dp[i] = new int[l2+1];
            Array.Fill(dp[i], int.MinValue);
        }
        
        //base case
        dp[1][1] = nums1[0]*nums2[0];
        
        for(var i = 1; i <= l1; ++i){
            for(var j = 1; j <= l2; ++j){
                if(i == 1 && j == 1) continue;
                if(i == 1 || j == 1){
                    dp[i][j] = nums1[i-1]*nums2[j-1];
                    dp[i][j] = Math.Max(dp[i][j], Math.Max(dp[i-1][j], dp[i][j-1]));
                    //Console.WriteLine($"dp[{i}][{j}]={dp[i][j]}");
                    continue;
                }
                dp[i][j] = nums1[i-1]*nums2[j-1] + Math.Max(dp[i-1][j-1], 0);
                // dp[i][j] = Math.Max(dp[i][j], dp[i-1][j-1] + nums1[i-1]*nums2[j-1]);           
                dp[i][j] = Math.Max(dp[i][j], dp[i-1][j]);
                dp[i][j] = Math.Max(dp[i][j], dp[i][j-1]);
                //Console.WriteLine($"dp[{i}][{j}]={dp[i][j]}");
            }
        }
        return dp[l1][l2];
    }
}