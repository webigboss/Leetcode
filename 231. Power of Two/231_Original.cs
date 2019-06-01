public class Solution {
    public bool IsPowerOfTwo(int n) {
        if(n == 0)
            return false;
        if(n == 1)
            return true;
        
        
        long result = 2;
        long carryOver = 1;
        while(true){
            if(result * carryOver == n)
                return true;
            if(result * carryOver > n)
                break;
            if(result * result * carryOver > n){
                carryOver *= result;
                result = 2;
            }
            else
                result = result * result;
        }
        return false;
    }
}