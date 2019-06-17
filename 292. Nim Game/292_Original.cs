public class Solution {
    public bool CanWinNim(int n) {
        //try on paper you will get the pattern, only number that can divided by 4 will lose.
        return n % 4 != 0;
    }
}