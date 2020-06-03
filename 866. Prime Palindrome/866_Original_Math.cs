public class Solution {
    public int PrimePalindrome(int N) {
        var sb = new StringBuilder();
        for(var L = 1; L <= 5; ++L){
            //odd case
            for(var k = Math.Pow(10, L-1); k < Math.Pow(10, L); ++k){
                sb.Clear();
                sb.Append(k);
                var strK = k.ToString();
                for(var i = L-2; i>=0; --i)
                    sb.Append(strK[i]);
                strK = sb.ToString();
                //Console.WriteLine($"odd - strK:{strK}");
                if(int.Parse(strK) >= N && IsPrime(strK))
                    return int.Parse(strK);
            }
            
            //even case
            for(var k = Math.Pow(10, L-1); k < Math.Pow(10, L); ++k){
                sb.Clear();
                sb.Append(k);
                var strK = k.ToString();
                for(var i = L-1; i>=0; --i)
                    sb.Append(strK[i]);
                strK = sb.ToString();
                //Console.WriteLine($"even - strK:{strK}");
                if(int.Parse(strK) >= N && IsPrime(strK))
                    return int.Parse(strK);
            }
        }
        return 0;
    }
    
    bool IsPrime(string s){
        // Console.WriteLine($"IsPrime({s})");
        var n = int.Parse(s);
        if(n < 2) return false;
        int sqrt = (int)Math.Sqrt(n);
        for(var i = 2; i <= sqrt; ++i){
            if(n%i==0) return false;
        }
        return true;
    }
}