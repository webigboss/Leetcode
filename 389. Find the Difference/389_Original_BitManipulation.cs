public class Solution {
    public char FindTheDifference(string s, string t) {
        //bit manipulation approach:
        //e.g. use int array for example, char is essentially ASCII int so idea is the same
        // t= [5,2] => base2 [0101, 0010], s=[2] => [0010]
        // (1) c ^= 5 => 0000 ^ 0101 = 0101
        // (2) c ^= 2 => 0101 ^ 0010 = 0111
        // (3) c ^= 2 => 0111 ^ 0101 = 0010 = 5
        // so answer is 5
        int c = 0;
        for(var i = 0; i < t.Length; i++){
            if(i < s.Length)
                c ^= s[i];
            c ^= t[i];
        }
        return (char)c;
    }
}