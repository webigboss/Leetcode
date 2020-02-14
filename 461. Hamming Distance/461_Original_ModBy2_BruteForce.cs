public class Solution {
    public int HammingDistance(int x, int y) {
        var result = 0;
        while(x > 0 || y > 0) {
            if(x % 2 != y % 2)
                result++;
            x /= 2;
            y /= 2;
        }
        return result;
    }
}