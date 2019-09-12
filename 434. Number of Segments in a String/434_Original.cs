public class Solution {
    public int CountSegments(string s) {
        var prevChar = ' ';
        var result = 0;
        foreach(var c in s){
            if(c != ' ' && prevChar == ' ')
                result++;
            
            prevChar = c;
        }
        return result;
    }
}