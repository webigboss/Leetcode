public class Solution {
    public string DecodeAtIndex(string S, int K) {
        long size = 0;
        int n = S.Length;
        for(var i = 0; i < n; ++i){
            if(Char.IsDigit(S[i]))
                size *= S[i]-'0';
            else
                size++;
        }
        //Console.WriteLine(size);
        for(var i = n-1; i>= 0; --i){
            K = (int)(K%size);
            if(K == 0 && Char.IsLetter(S[i]))
                return S[i].ToString();
            
            if(Char.IsDigit(S[i]))
                size /= S[i]-'0';
            else
                size--;
        }
        return string.Empty;
    }
}