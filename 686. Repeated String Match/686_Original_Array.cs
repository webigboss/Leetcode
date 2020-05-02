public class Solution {
    public int RepeatedStringMatch(string A, string B) {
        var count = 0;
        int i = 0, j = 0;
        
        for(var k = 0; k < A.Length; ++k){
            i = k;
            var isans = true;
            count = i == 0 ? 0 : 1;
            while(j < B.Length){
                i %= A.Length;
                if(i == 0)
                    count++;

                if(A[i] == B[j]){
                    i++;
                    j++;
                }
                else{
                    isans = false;
                    j = 0;
                    break;  
                }
            }
            
            if(isans)
                return count;
        }
        return -1;
    }
}