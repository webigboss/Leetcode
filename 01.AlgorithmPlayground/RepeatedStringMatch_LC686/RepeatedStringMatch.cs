namespace AlgorithmPlayground
{
    public class RepeatedStringMatch
    {
        public RepeatedStringMatch()
        {
            var a = "aaac";
            var b = "aac";
            var ans = Solution(a, b);
        }
        public int Solution(string A, string B)
        {
            var count = 0;
            var j = 0;
            for (var i = 0; i < A.Length; ++i)
            {
                var isans = true;
                count = i == 0 ? 0 : 1;
                while (j < B.Length)
                {
                    i %= A.Length;
                    if (i == 0)
                        count++;

                    if (A[i] == B[j])
                    {
                        i++;
                        j++;
                    }
                    else
                    {
                        isans = false;
                        j = 0;
                        break;
                    }
                }

                if (isans)
                    return count;
            }
            return -1;
        }
    }
}