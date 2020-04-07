using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace AlgorithmPlayground
{
    //https://leetcode.com/discuss/interview-question/460127/
    public class TopNBuzzWords
    {
        public TopNBuzzWords()
        {
            var numToys = 6;
            var topToys = 2;
            var toys = new[]{"legos", "drone", "tablet", "elmo", "warcraft", "elsa"};
            var numQuotes = 6;
            var quotes = new []{
                "Elmo is the hottest of the season! Elmo will be on every kid's wishlist!",
                "The new Elmo dolls are super high quality",
                "Expect the Elsa dolls to be very popular this year, Elsa!",
                "Elsa and Elmo are the toys I'll be buying for my kids, Elsa is good",
                "For parents of older kids, look into buying them a drone",
                "Warcraft is slowly rising in popularity ahead of the holiday season"
            };
            var result  = GetTopNWords(numToys, topToys, toys, numQuotes, quotes);
        }

        public IList<string> GetTopNWords(int numToys, int topToys, string[] toys, int numQuotes, string[] quotes)
        {
            var result = new List<string>();
            var dict = new Dictionary<string, int>();

            foreach(var t in toys) {
                dict[t.ToLower()] = 0;
            }
            foreach(var q in quotes){
                var words = Regex.Split(q, @"\W");

                foreach(var w in words){
                    if(dict.ContainsKey(w.ToLower())) dict[w.ToLower()]++;
                }
            }
            var kvpList = dict.ToList();
            kvpList.Sort((a, b) => {
                if(a.Value == b.Value)
                    return a.Key.CompareTo(b.Key);
                return b.Value - a.Value;
            });
            for(var i = 0; i < topToys; ++i){
                result.Add(kvpList[i].Key);
            }
            return result;
        }

    }
}