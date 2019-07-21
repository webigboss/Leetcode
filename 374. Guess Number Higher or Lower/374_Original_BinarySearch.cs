public class Solution GuessGame {
    public int guessNumber(int n) {
        long lo = 1;
        long hi = n;
        long mid;
        int ans;
        while(true){
            mid = (lo + hi) / 2;
            ans = guess((int)mid);
            if(ans == 0)
                break;
            if(ans == 1)
                lo = mid + 1;
            else
                hi = mid - 1;
        }
        return (int)mid;
    }
}