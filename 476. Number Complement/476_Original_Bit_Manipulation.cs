public class Solution {
    public int FindComplement(int num) {
        var bitLength = (int)Math.Log(num, 2) + 1;
        var shiftLength = 32 - bitLength;
        return ~num << shiftLength >> shiftLength;
    }
}