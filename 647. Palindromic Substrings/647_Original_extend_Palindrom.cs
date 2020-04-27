public class Solution {
    public int CountSubstrings(string s) {
        var ans = 0;
        for(var i = 0; i < s.Length; ++i){
            ans += FindAt(s, i, i);
            ans += FindAt(s, i, i + 1);
        }
        return ans;
    }
    
    private int FindAt(string s, int l, int r){
        var count = 0;
        while(l >= 0 && r < s.Length){
            if(s[l] != s[r])
                break;
            count++;
            l--;
            r++;
        }
        return count;
    }
}