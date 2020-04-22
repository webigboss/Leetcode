public class Solution {
    public bool JudgeSquareSum(int c) {
        //brute force
        if(c == 0) return true;
        int sqrt = (int)Math.Sqrt((double)c);
        for(var i = 1; i <= sqrt; ++i){
            int n = c - i*i;
            int sqrtn = (int)Math.Sqrt((double)n);
            if(sqrtn * sqrtn == n) return true;
        }
        return false;
    }
}