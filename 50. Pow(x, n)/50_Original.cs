public class Solution {
    public double MyPow(double x, int n) {
        double result = 1;
        double temp = x;
        long p = 1;
        long n2 = (long)n;
        if(n2 == 0){
            return 1;
        }
        var isnegative = n2 < 0; 
        n2 = Math.Abs(n2);
        
        while(true){
            if(n2 == 0){
                break;
            }
            if(p * 2 <= n2){
                temp = temp * temp;
                p = p * 2;
            }
            else{
                result *= temp;
                n2 -= p;
                p = 1;
                temp = x;
            }
        }
        return isnegative ? 1/result : result;
    }
}