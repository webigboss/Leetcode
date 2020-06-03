public class Solution {
    public int BinaryGap(int N) {
        int ans = 0, prev = -1, log2 = 0;
        while(N > 0){
            log2 = (int)Math.Log(N, 2);
            // Console.WriteLine($"log2:{log2}");
            if(prev != -1)
                ans = Math.Max(ans, prev - log2);
            prev = log2;
            N -= (int)Math.Pow(2, log2);
            // Console.WriteLine($"New N: {N}, ans:{ans}, prev:{prev}");
        }
        return ans;
    }
}