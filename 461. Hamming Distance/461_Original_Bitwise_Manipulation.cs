public class Solution {
    public int HammingDistance(int x, int y) {
        //bitwise operation
        var a = x ^ y;
        var result = 0;
        while(a != 0){
            a &= a - 1;
            result++;
        }
        return result;
    }
}