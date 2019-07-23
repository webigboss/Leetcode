public class Solution {
    public int FindNthDigit(int n) {
        var length = 1;
        var numberBase = 9;
        long start = 1;
        long sum = 0;

        while(sum + start * numberBase * length < n){
            sum += start * numberBase * length;
            length++;
            start *= 10;
        }

        //!!!! subtal but important, need to subtract 1, consider n = 10, n-sum = 1; it will lead to the second digit, but we need the first.
        var actualNum = start + (n - sum - 1) / length;

        var digitIndex = (n - sum - 1) % length;

        int digit = actualNum.ToString()[(int)digitIndex] - '0';
        return digit;
    }
}