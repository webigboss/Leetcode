using System.Collections.Generic;
using System.Text;

namespace AlgorithmPlayground
{
    public class FindGroupsOfAnagrams
    {
        public FindGroupsOfAnagrams()
        {
            var strs = new []{
                "eat", "tea", "tan", "ate", "nat", "bat"
            };
            var result = GroupAnagrams(strs);
        }
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dict = new Dictionary<string, IList<string>>();
            var letterCounts = new int[26];
            var sb = new StringBuilder();
            foreach (var s in strs)
            {
                letterCounts = new int[26];
                sb.Clear();
                foreach (var c in s)
                    letterCounts[c - 'a']++;

                foreach (var i in letterCounts)
                {
                    sb.Append(i.ToString());
                    sb.Append('|');
                }

                var key = sb.ToString();
                if(!dict.ContainsKey(key))
                    dict[key] = new List<string>();
                dict[key].Add(s);
            }
            var result = new List<IList<string>>();
            foreach(var list in dict.Values){
                result.Add(list);
            }
            return result;
        }
    }


}