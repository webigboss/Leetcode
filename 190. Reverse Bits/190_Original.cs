public class Solution {
    public uint reverseBits(uint n) {
        var sb = new StringBuilder();
            while (n >= 1){
                sb.Append(n % 2);
                n /= 2;
            }
            //already revered by doing appending
            var bit = sb.ToString().PadRight(32, '0');
            uint result = 0;
            for (var i = 0; i < bit.Length; i++){
                if (bit[i] == '1'){
                    result += (uint)Math.Pow(2, bit.Length - 1 - i);
                }
            }
            return result;
    }
}
