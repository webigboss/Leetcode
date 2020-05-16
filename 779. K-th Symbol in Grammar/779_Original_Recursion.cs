public class Solution {
    public int KthGrammar(int N, int K) {
        if(N == 1 && K == 1) return 0;
        
        if(((K-1) % 2) == 0)
            return KthGrammar(N-1, (int)((K-1)/2) + 1);
        
        else
            return 1 - KthGrammar(N-1, (int)((K-1)/2) + 1);
    }
}