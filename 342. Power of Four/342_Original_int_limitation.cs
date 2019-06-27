//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
//!!!!!!!!this approach only works for prime numbers, 4 is not a prime number so it doesn't work
public class Solution {
    public bool IsPowerOfFour(int num) {
        // int limitation approach 
        // max power of 4 with 32-bit signed int: 1,073,741,824
        if (num <= 0) return false;
        return 1073741824 % num == 0;
    }
} 