public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        if(g == null || g.Length == 0 || s == null || s.Length == 0)
            return 0;
        Array.Sort(g);
        Array.Sort(s);
        
        var count = 0;
        var iChild = 0;
        for(var i = 0; i < s.Length; i++){
            if(iChild == g.Length) break;
            if(s[i] >= g[iChild]) {
                count++;
                iChild++;
            }
        }
        return count;
    }
}