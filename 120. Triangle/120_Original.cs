public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        if(triangle == null || triangle.Count == 0 || triangle[0].Count == 0)
            return 0;
        var dp = new int[triangle.Count][];
        for(var i = 0; i < triangle.Count; i++){
            dp[i] = new int[triangle[i].Count];
            //base case
            if(i == triangle.Count - 1){
                for(var j = 0; j < triangle[i].Count; j++){
                    dp[i][j] = triangle[i][j];
                }
            }
        }
        
        for(var i = triangle.Count - 2; i >= 0; i--){
            for(var j = 0; j < triangle[i].Count; j++){
                dp[i][j] = triangle[i][j] + Math.Min(dp[i + 1][j], dp[i + 1][j + 1]);
            }
        }
        
        return dp[0][0];
    }
}