public class Solution {
    public int MaxScore(string s) {
        var sumAt = new int[s.Length];
        for(var i = 0; i < s.Length; ++i){
            if(i == 0){
                sumAt[i] = s[i] == '1' ? 1 : 0;
                continue;
            }
            sumAt[i] = s[i] == '1' ? sumAt[i - 1] + 1: sumAt[i - 1];
        }
        //return sumAt[0];
        var ans = 0; 
        for(var i = 0; i < sumAt.Length - 1; ++i){
            var left = i + 1 - sumAt[i];
            var right = sumAt[sumAt.Length - 1] - sumAt[i];
            ans = Math.Max(ans, left + right);
        }
        return ans;
    }
}