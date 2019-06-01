public class Solution {
    public int RangeBitwiseAnd(int m, int n) {
        int ans = 0;
        int step = 1;
        while(n > 0 && m > 0){
            //if 1. m < n, then there must be at least an even number exists, meaning the last binary number is 0, so bitwise AND of last binary number must be 0;
            //   2. m == n, but if m and n are both even, the the bitwise AND of last binary number will be also 0;
            ans += step * (n == m && n % 2 == 1 && m % 2 == 1 ? 1 : 0);
            step *= 2;
            n /= 2;
            m /= 2;
        }
        return ans;
    }
}