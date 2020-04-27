public class Solution {
    public int MaxScore(int[] cardPoints, int k) {
        var ans = 0;
        var sum = 0;
        for(var i = 0; i < k; ++i)
            sum+= cardPoints[i];
        
        if(k == cardPoints.Length)
            return sum;
        ans = sum;
        for(var j = k - 1; j >= 0; --j){
            sum = sum - cardPoints[j] + cardPoints[j - k + cardPoints.Length];
            ans = Math.Max(ans, sum);
        }
        return ans;
    }
}