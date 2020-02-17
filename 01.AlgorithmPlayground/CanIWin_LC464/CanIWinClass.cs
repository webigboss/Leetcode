using System;
using System.Collections.Generic;

namespace AlgorithmPlayground
{
    public class CanIwinClass
    {
        public CanIwinClass()
        {
            var maxChoosableInteger = 10;
            var desiredTotal = 11;
            var result = CanIWin(maxChoosableInteger, desiredTotal);
        }
        public bool CanIWin(int maxChoosableInteger, int desiredTotal)
        {
            //top-down DP with memoization
            if (desiredTotal <= 0) return true;
            var sum = (1 + maxChoosableInteger) * maxChoosableInteger / 2;
            if (sum < desiredTotal) return false;
            var visited = new char[maxChoosableInteger];
            for (var i = 0; i < visited.Length; i++)
            {
                visited[i] = '0';
            }
            var memo = new Dictionary<string, bool>();

            return Helper(desiredTotal, visited, memo);
        }

        private bool Helper(int remaining, char[] visited, Dictionary<string, bool> memo)
        {
            if (remaining <= 0)
                return false;
            var key = new String(visited);
            if (!memo.ContainsKey(key))
            {
                for (var i = 0; i < visited.Length; i++)
                {
                    if (visited[i] == '1') continue;
                    visited[i] = '1';
                    if (!Helper(remaining - i - 1, visited, memo))
                    {
                        memo[key] = true;
                        visited[i] = '0';
                        return true;
                    }
                    visited[i] = '0';
                }
                //if didn't get any true after interation of all possible integers, set the key's value to false;
                memo[key] = false;
            }
            return memo[key];
        }
    }
}