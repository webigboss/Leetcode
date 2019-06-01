public class Solution {
    public int CountPrimes(int n) {
        //sieve of Eratosthenes approach
        var isPrime = new bool[n];
        for(var i = 0; i < n; i++)
            isPrime[i] = true;
        
        for(var i = 2; i * i < n; i++){
            if(!isPrime[i])
                continue;
            for(var j = i * i; j < n; j += i){
                isPrime[j] = false;
            }
        }
        
        var primeCount = 0;
        for(var i = 2; i < n; i++){
            if(isPrime[i])
                primeCount++;
        }
        
        return primeCount;
    }
}