using System;

namespace AlgorithmPlayground
{
    public class UniqueSubstringinWraparoundString
    {
        public UniqueSubstringinWraparoundString()
        {
            var p = "zab";
            var result = FindSubstringInWraproundString(p);
        }
        public int FindSubstringInWraproundString(string p)
        {
            var count = 1;
            //dp array to store the max length of substr ing ends with a specific lower case alphabet
            var dp = new int[26];
            for (var i = 0; i < p.Length; i++)
            {
                if (i >= 1)
                {
                    if (p[i] - p[i - 1] == 1 || p[i] == 'a' && p[i - 1] == 'z')
                        count++;
                    else
                        count = 1;
                }
                dp[p[i] - 'a'] = Math.Max(dp[p[i] - 'a'], count);
            }

            var result = 0;
            //avoid double counting, only count the unique count of all substrings that end with a specific alphabet
            //e.g. if for d, count ==4, meaning the max substring is abcd, them the count of all possible unique substring 
            //that ends with d will equals the count itself, because the are abcd, bcd, cd, d
            //also need to populate the dp with the max length for substrings ends with alphabet before current one. like abcd, for d max length is 4, and c is 3 
            for (var i = 0; i < dp.Length; i++)
            {
                result += dp[i];
            }
            return result;
        }
    }
}
