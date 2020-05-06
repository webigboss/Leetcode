public class Solution {
    public bool IsOneBitCharacter(int[] bits) {
        var n = bits.Length;
        for(var i = 0; i < n; ++i){
            if(bits[i] == 1)
                i++;
            else if(i == n-1)
                return true;
        }
        return false;
    }
}