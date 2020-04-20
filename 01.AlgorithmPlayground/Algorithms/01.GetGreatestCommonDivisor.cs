using System;

namespace AlgorithmPlayground
{
    public static class GreatestCommonDivisor
    {
        public static int GetGCD(int a, int b)
        {
            if (a == 0 || b == 0) return Math.Abs(a + b);
            //the important part is swapping the b to the first parameter to cope of cases when a < b,
            //thus next recursion it will be calling GetGCD(b, a)
            return GetGCD(b, a % b);
        }
    }
}