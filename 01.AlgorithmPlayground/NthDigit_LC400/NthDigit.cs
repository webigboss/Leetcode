using System;

namespace AlgorithmPlayground{
    public class NthDigit {
        public NthDigit(){
            //var i = findNthDigitJ(1000);
            var i = FindNthDigit(1000000000);
        }

        public int findNthDigitJ(int n) {
		    int len = 1;
		    int count = 9;
		    int start = 1;

            while (n > len * count) {
                n -= len * count;
                len += 1;
                count *= 10;
                start *= 10;
            }

		    start += (n - 1) / len;
		    var s = start.ToString();
            var index = (n - 1) % len;
		    return s[index] - '0';
	    }

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
            
            var actualNum = start + (n - sum - 1) / length;
            //!!!! sutal but important, need to subtract 1, consider n = 10, n-sum = 1; it will lead to the second digit, but we need the first.
            var digitIndex = (n - sum - 1) % length;
            
            int digit = actualNum.ToString()[(int)digitIndex] - '0';
            return digit;
        }
    }
}