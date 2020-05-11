public class Solution {
    public IList<string> BuildArray(int[] target, int n) {
        var ans = new List<string>();
        var j = 0;
        for(var i = 1; i <= n; ++i){
            if(i < target[j]){
                ans.Add("Push");
                ans.Add("Pop");
            }
            else if (i == target[j]){
                ans.Add("Push");
                j++;
                if(j == target.Length)
                    break;
            }
        }
        return ans;
    }
}