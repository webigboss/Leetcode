public class Solution {
    public char NextGreatestLetter(char[] letters, char target) {
        char min = 'z', ans = '{'; //{ is next ASCII char after z
        foreach(var c in letters){
            min = (char)Math.Min((int)min, (int)c);
            if(c > target)
                ans = (char)Math.Min((int)ans, (int)c);
            
        }
        return ans == '{' ? min : ans;
    }
}