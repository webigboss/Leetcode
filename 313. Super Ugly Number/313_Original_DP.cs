public class Solution {
    public int NthSuperUglyNumber(int n, int[] primes) {
        var pindex = new int[primes.Length];
        var dp = new int[n];
        //base case 
        dp[0] = 1;
        
        for(var i = 1; i < n; i++){
            var minNumber = int.MaxValue;
            int minIndex = 0;
            for(var j = 0; j < pindex.Length; j++){
                var temp = dp[pindex[j]] * primes[j];
                //if(temp == dp[i - 1]) continue;
                //if(temp < minNumber && temp > dp[i - 1]){
                if(temp < minNumber){
                    minNumber = temp;
                    minIndex = j;
                }
            }
            
            for(var j = 0; j < pindex.Length; j++){
                if(dp[pindex[j]] * primes[j] == minNumber){
                    pindex[j]++;
                }
            }
            dp[i] = minNumber;
        }
        return dp[n - 1];
    }
}