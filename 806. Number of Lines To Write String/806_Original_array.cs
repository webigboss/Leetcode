public class Solution {
    public int[] NumberOfLines(int[] widths, string S) {
        var l = 0;
        var w = 0;
        foreach(var c in S){
            if(w + widths[c-'a'] > 100){
                l++;
                w = widths[c-'a'];
            }
            else
                w += widths[c-'a'];
        }
        return new []{l+1, w};
    }
}