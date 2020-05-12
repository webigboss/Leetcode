public class Solution {
    public int CountPrimeSetBits(int L, int R) {
        var primes = new HashSet<int>(new []{2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37});
        var ans = 0;
        for(var i = L; i <= R; ++i){
            var bitCount = BitCount(i);
            if(primes.Contains(bitCount))
                ans++;
        }
        return ans;
    }
    
    private int BitCount(int num){
        var ans = 0;
        while(num > 0){
            num &= num - 1;
            ans++;
        }
        return ans;
    }
}