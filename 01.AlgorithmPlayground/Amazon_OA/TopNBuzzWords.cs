using System.Collections.Generic;

namespace AlgorithmPlayground
{
    public class TopNBuzzWords
    {
        public TopNBuzzWords()
        {
            var numToys = 6;
            var topToys = 2;
            var toys = new[]{"elmo", "elsa", "legos", "drone", "tablet", "warcraft"};
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


            return result;
        }

    }
}