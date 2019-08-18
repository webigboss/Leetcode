using System;

namespace AlgorithmPlayground
{
    public class RotateFunction
    {
        public RotateFunction()
        {
            var a = new int[] { -2147483648, -2147483648 };
            var result = MaxRotateFunction(a);
        }
        public int MaxRotateFunction(int[] A)
        {
            var n = A.Length;
            long result = 0;

            for (var i = 0; i < n; i++)
            {
                long tempResult = 0;
                for (var j = 0; j < n; j++)
                {
                    var index = i + j < n ? (i + j) : (i + j - n);
                    tempResult += ((long)A[index]) * j;
                }
                result = Math.Max(result, tempResult);
            }

            return (int)result;
        }
    }
}