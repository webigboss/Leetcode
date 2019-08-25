public class Solution {
    public int NumberOfArithmeticSlices(int[] A) {
        //if the max length of a arithmetic sequence(等差数列) is n, then the total number of its arithmetic slices is the sum of 1, 2, ..., (n - 3 + 1)
        // = (1 + n - 3 + 1) * (n - 3 + 1) / 2 = (n - 1)(n - 2)/2
        var result = 0;
        var count = 0;
        for(var i = 2; i < A.Length; i++){
            if(A[i] - A[i - 1] == A[i - 1] - A[i - 2]){
                if(count == 0) count = 3;
                else count++;
            }
            else{
                if(count != 0)
                    result += (count - 1) * (count - 2) / 2;
                count = 0;
            }
        }
        if(count != 0)
            result += (count - 1) * (count - 2) / 2;
        
        return result;
    }
}