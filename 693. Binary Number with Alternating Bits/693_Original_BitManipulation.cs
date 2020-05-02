public class Solution {
    public bool HasAlternatingBits(int n) {
        var isOdd = (n%2 == 1);
        while(n != 0){
            if(isOdd && (n&1) == 1 || !isOdd && (n&1) == 0){
                n >>= 1;
                isOdd = !isOdd;
            }
            else {
                return false;
            }
        }
        return true;
    }
}