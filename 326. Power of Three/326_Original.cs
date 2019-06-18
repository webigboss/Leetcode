public class Solution {
    public bool IsPowerOfThree(int n) {
        if(n == 1) return true;
        if(n % 3 != 0) return false;
        long result = 1;
        long i = 3;
        while(true){    
            while(result * i < (long)n){
                result *= i;
                i = i * i;
            }
            if(result * i == (long)n)
                return true;
            i = 3;
            if(result * i > (long)n)
                return false;
        }
        return false;
    }
}