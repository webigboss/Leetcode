public class Solution {
    public int IntegerReplacement(int n) {
        // check if last 2 bit numbers 11
        var ln = (long)n;
        var result = 0;
        while(ln != 1){
            if((ln & 1) == 1){
                // ln & 3 checks if n ends with 11 in bit number, ln != 3 prevent a spacial case when ln = 3, we should in fact decrease ln;
                if((ln & 3) == 3 && ln != 3) 
                    ln++;
                result++;
            }
            ln >>= 1;
            result++;
        }
        return result;
    }
}