using System.Collections.Generic;
using System;

namespace AlgorithmPlayground
{
    public class FrogCroaking
    {

        public FrogCroaking()
        {
            var croakOfFrogs = "croakcrook";
            var result = MinNumberOfFrogs(croakOfFrogs);
        }

        public int MinNumberOfFrogs(string croakOfFrogs)
        {
            var dict = new Dictionary<char, int>();
            dict['r'] = 0;
            dict['o'] = 0;
            dict['a'] = 0;
            dict['k'] = 0;
            var result = 0;
            var frogs = 0;
            foreach (var c in croakOfFrogs)
            {
                if (!dict.ContainsKey(c))
                {//'c'
                    dict['r']++;
                    frogs++;
                    result = Math.Max(frogs, result);
                }
                else
                {
                    if (dict[c] == 0) return -1;
                    dict[c]--;
                    if (c == 'r')
                        dict['o']++;
                    if (c == 'o')
                        dict['a']++;
                    if (c == 'a')
                        dict['k']++;
                    if (c == 'k')
                    {
                        frogs--;
                    }
                }
            }
            return result;
        }

    }
}