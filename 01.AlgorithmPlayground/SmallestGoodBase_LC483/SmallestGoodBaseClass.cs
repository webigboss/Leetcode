using System;
using System.Numerics;
namespace AlgorithmPlayground
{
    public class SmallestGoodBaseClass
    {
        public SmallestGoodBaseClass()
        {
             var result = SmallestGoodBase("16035713712910627");
            //var result = SmallestGoodBase("219661");

        }
        public string SmallestGoodBase(string n)
        {
            // long == Int64. range is -2^63 ~ 2^63-1, 2^60 is about 1.5E10^18, which is gauranteed to be big than n 
            //any number n can be 11 of base n-1, that is because (n-1)^0+(n-1)^1=1+n-1=1, so 2 is a gaurateed answer for any number;
            //so 1st level iteration which is on the possible pow, will be from 60(if base is close to 2) to 2(base is n-1)
            long nl = long.Parse(n);
            long upperBound = (long)Math.Pow(10, 18);
            for (var m = 60; m >= 2; m--)
            {
                //2nd level iteration use binary search
                long lo = 2;

                //long hi = nl - 1; <-- this will be too big and unncessary, find the root of upperBound is better
                long hi = (long)Math.Pow(upperBound, (double)1 / (m - 1));
                long mid = 0;
                BigInteger valueToCompare = 0;
                while (lo <= hi)
                {
                    mid = (lo + hi) / 2;
                    //cannot use Math.Pow because it returns a double, which isn't precise, it only keep around 15 decimal place
                    //for long 1234567890123456789, it will be something like 1.23456789012345E18
                    valueToCompare = (BigInteger.Pow(mid, m) - 1) / (mid - 1);

                    //based on the equation nl = (k^m - 1)/(k - 1), calculate (k^m - 1)/(k - 1)
                    //if (k^m-1)/k-1 < nl, k needs to be bigger, vice versa, if equal to nl, return as answer;
                    if (valueToCompare == nl) return mid.ToString();

                    //way to exit the while loop when lo == hi, after check lo(hi, also mid) is not the answer, 
                    //without doing this will result in infinit loop;
                    if (lo == hi) break;

                    if (valueToCompare < nl && valueToCompare > 0)
                        lo = mid + 1;
                    else
                        hi = mid - 1;
                }
            }
            return string.Empty;
        }
    }
}