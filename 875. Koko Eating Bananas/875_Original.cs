public class Solution {
    public int MinEatingSpeed(int[] piles, int H) {
        long sum = 0;
        int k = 0, n = piles.Length, cur = 0, max = 0;
        foreach(var p in piles){
            sum += p;
            max = Math.Max(max, p);
        }
        //min k
        k = (int)((sum+H-1)/H);
        //Console.WriteLine(k);
        while(k < max){
            cur = 0;
            bool isValid = true;
            for(var i = 0; i < n && isValid; ++i){
                cur += (piles[i]+k-1)/k;
                if(cur > H) isValid = false;
            }
            if(isValid)
                break;
            k++;
        }
        return k;
    }
}