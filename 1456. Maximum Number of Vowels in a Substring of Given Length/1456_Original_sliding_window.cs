public class Solution {
    public int MaxVowels(string s, int k) {
        int ans = 0, cur = 0;
        var v = new HashSet<char>{'a','e','i','o','u'};
        for(var i = 0; i < s.Length; ++i){
            if(v.Contains(s[i])) 
                cur++;
            if(i >= k && v.Contains(s[i-k]))
                cur--;
            ans = Math.Max(ans, cur);
        }
        return ans;
    }
}