namespace AlgorithmPlayground
{
    public class IntegerReplacementClass
    {
        public IntegerReplacementClass(){
            var n = 2147483647;
            var result = IntegerReplacement(n);
        }
        public int IntegerReplacement(int n)
        {
            var result = 0;

            while (n != 1)
            {
                if ((n & 1) == 1)
                {
                    if (BitCount((long)n - 1) >= BitCount((long)n + 1) && n != 3)
                        n++;
                    result++;
                }
                n >>= 1;
                result++;
            }
            return result;
        }

        private int BitCount(long n)
        {
            var count = 0;
            while (n != 0)
            {
                if ((n & 1) == 1) // odd
                    count++;
                n >>= 1;
            }
            return count;
        }
    }
}