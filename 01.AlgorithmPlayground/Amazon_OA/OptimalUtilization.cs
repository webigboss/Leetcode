using System;
using System.Collections.Generic;

namespace AlgorithmPlayground
{
    //https://leetcode.com/discuss/interview-question/373202
    public class OptimalUtilization
    {
        public OptimalUtilization()
        {
            var a = new[]{
                new [] {1, 3},
                new [] {2, 5},
                new [] {3, 7},
                new [] {4, 10}
                };
            var b = new[]{
                new [] {1, 2},
                new [] {2, 3},
                new [] {3, 4},
                new [] {4, 5}
                };
            var target = 10;
            var result = FindOptimalUtilization(a, b, target);

            a = new[]{
                new [] {1, 8},
                new [] {2, 7},
                new [] {3, 14},
                };
            b = new[]{
                new [] {1, 5},
                new [] {2, 10},
                new [] {3, 14},
                };
            target = 20;
            result = FindOptimalUtilization(a, b, target);

            a = new[]{
                new [] {1, 8},
                new [] {2, 15},
                new [] {3, 9},
                };
            b = new[]{
                new [] {1, 8},
                new [] {2, 11},
                new [] {3, 12},
                };
            target = 20;
            result = FindOptimalUtilization(a, b, target);
        }
        public int[][] FindOptimalUtilization(int[][] a, int[][] b, int target)
        {
            var dict = new Dictionary<int, List<int[]>>();
            Array.Sort(a, (x, y) => x[1] - y[1]);
            Array.Sort(b, (x, y) => x[1] - y[1]);
            int lo, hi, maxVal, temphi;
            lo = 0;
            hi = b.Length - 1;
            maxVal = -1;
            while (lo < a.Length && hi >= 0)
            {
                if (a[lo][1] + b[hi][1] > target)
                {
                    --hi;
                    continue;
                }
                if (a[lo][1] + b[hi][1] >= maxVal)
                {
                    maxVal = a[lo][1] + b[hi][1];
                    temphi = hi;
                    while(temphi >= 0){
                        if(a[lo][1] + b[temphi][1] == maxVal){
                            if(!dict.ContainsKey(maxVal))
                                dict[maxVal] = new List<int[]>();
                            dict[maxVal].Add(new []{a[lo][0], b[temphi][0]});
                        }
                        else break;
                        --temphi;
                    }
                    ++lo;
                }
            }
            return dict[maxVal].ToArray();
        }
    }
}