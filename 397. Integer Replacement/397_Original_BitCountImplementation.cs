public class Solution {
    public int IntegerReplacement(int n) {
        //BitCount implementation approach
        var result = 0;
        var ln = (long)n;
        while(ln != 1){
            if((ln & 1) == 1) {
                if(BitCount(ln - 1) >= BitCount(ln + 1) && ln != 3)
                    ln++;
                result++;
            }
            ln >>= 1;
            result++;
        }
        return result;
    }
    
    private int BitCount(long n){
        var count = 0;
        while(n != 0){
            if((n & 1) == 1) // odd
                count++;
            n >>= 1;
        }
        return count;
    }
}