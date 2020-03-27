using System;

namespace AlgorithmPlayground
{
    public class CompleteKnapsack
    {
        public CompleteKnapsack()
        {
            //test case found from: https://en.wikipedia.org/wiki/Knapsack_problem
            // expected result: ?
            var values = new[]{
                505,352,458,220,354,414,498,545,473,543
            };
            var weights = new[]{
                23,26,20,18,32,27,29,26,30,27
            };
            var capacity = 67;
            var result = Solution(values, weights, capacity);
            var result2 = Solution_Space_Optimized(values, weights, capacity);
        }

        //n: values.Length; m: capacity
        //Time complxity: O(n*m), 
        //Space complexity: O(n*m*Σ(m/weights[i]))
        public int Solution(int[] values, int[] weights, int capacity)
        {
            var l = values.Length;
            var dp = new int[l + 1][];
            for (var i = 0; i < dp.Length; i++)
            {
                dp[i] = new int[capacity + 1];
            }

            for (var i = 1; i < dp.Length; i++)
            {
                for (var j = weights[i - 1]; j <= capacity; j++)
                {
                    dp[i][j] = dp[i - 1][j];
                    var count = 1;
                    while (count * weights[i - 1] <= j)
                    {
                        dp[i][j] = Math.Max(dp[i][j], dp[i - 1][j - count * weights[i - 1]] + count * values[i - 1]);
                        count++;
                    }
                }
            }

            return dp[l][capacity];
        }

        //n: values.Length; m: capacity
        //Time complxity: O(n*m), 
        //Space complexity: O(m)
        public int Solution_Space_Optimized(int[] values, int[] weights, int capacity)
        {
            var l = values.Length;
            var dp = new int[capacity + 1];

            for (var i = 0; i < l; i++)
            {
                //!!!!!!!!! itertate froward from the start to the end, think about it, just in this way we can transition from a 
                //state where current i item may have already been selected from 0-n times
                // to reduce the dimension of dp array!!!!!!!
                for (var j = weights[i]; j <= capacity; j++)
                {
                    dp[j] = Math.Max(dp[j], dp[j - weights[i]] + values[i]);
                }
            }

            return dp[capacity];
        }
    }
}