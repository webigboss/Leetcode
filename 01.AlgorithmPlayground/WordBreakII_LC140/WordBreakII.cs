using System.Collections.Generic;
using System.Text;

namespace AlgorithmPlayground
{
    public class WordBreakII
    {
        public WordBreakII()
        {
            var s = "catsanddog";
            var wordDict = new[] { "cats", "dog", "sand", "and", "cat" };
            var result = WordBreakDFS(s, wordDict);
        }

        public IList<string> WordBreak(string s, IList<string> wordDict)
        {
            //DP approach
            var dp = new Dictionary<int, List<string>>();
            dp[0] = new List<string> { "" };
            var hs = new HashSet<string>();
            foreach (var word in wordDict)
                hs.Add(word);
            var sb = new StringBuilder();
            for (var i = 0; i < s.Length; i++)
            {
                if (dp.ContainsKey(i))
                {
                    sb.Clear();
                    for (var j = i; j < s.Length; j++)
                    {
                        sb.Append(s[j]);
                        var cur = sb.ToString();
                        if (hs.Contains(cur))
                        {
                            if (!dp.ContainsKey(j + 1))
                                dp[j + 1] = new List<string>();
                            foreach (var prev in dp[i])
                            {
                                dp[j + 1].Add(string.IsNullOrEmpty(prev) ? cur : prev + " " + cur);
                            }
                        }
                    }
                }
            }
            return dp[s.Length];
        }

        public IList<string> WordBreakDFS(string s, IList<string> wordDict)
        {
            //DFS(recursion) with memo 
            return DfsHelper(s, wordDict, new Dictionary<string, IList<string>>());
        }

        private IList<string> DfsHelper(string s, IList<string> wordDict, Dictionary<string, IList<string>> dict)
        {
            if (dict.ContainsKey(s))
                return dict[s];

            if (string.IsNullOrEmpty(s))
            {
                return new List<string>();
            }
            var curResult = new List<string>();
            foreach (var word in wordDict)
            {
                if (s.StartsWith(word))
                {
                    var prevResult = DfsHelper(s.Substring(word.Length), wordDict, dict);
                    if(prevResult == null || prevResult.Count == 0)
                        curResult.Add(word);
                    foreach (var prev in prevResult)
                    {
                        curResult.Add(word + " " + prev);
                    }
                }
            }
            dict[s] = curResult;
            return curResult;
        }
    }
}