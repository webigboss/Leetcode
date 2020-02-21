using System.Collections.Generic;

namespace AlgorithmPlayground
{
    public class ConcatenatedWords
    {
        public ConcatenatedWords()
        {
            var words = new[] { "cat", "cats", "catsdogcats", "dog", "dogcatsdog", "hippopotamuses", "rat", "ratcatdogcat" };
            var result = FindAllConcatenatedWordsInADict(words);
        }
        public IList<string> FindAllConcatenatedWordsInADict(string[] words)
        {
            var trie = new Trie();
            foreach (var word in words)
                trie.Insert(word);
            var result = new List<string>();

            for (var i = 0; i < words.Length; i++)
            {
                if (Helper(words[i], trie, false))
                    result.Add(words[i]);
            }
            return result;
        }

        private bool Helper(string word, Trie trie, bool includeCurrentWord)
        {
            if (includeCurrentWord)
            {
                if (trie.Search(word)) return true;
            }
            var l = includeCurrentWord ? word.Length : word.Length - 1;
            for (var i = l - 1; i >= 0; i--)
            {
                var prefix = word.Substring(0, i + 1);
                if (trie.Search(prefix))
                {
                    word = word.Substring(i + 1, word.Length - i - 1);
                    if (Helper(word, trie, true)) return true;
                }
            }
            return false;
        }


        public class Trie
        {
            private Node root;

            public Trie()
            {
                root = new Node();
            }

            public class Node
            {
                public string Value { get; set; }
                public Dictionary<char, Node> Children { get; set; }
                public Node()
                {
                    Children = new Dictionary<char, Node>();
                }
            }

            public void Insert(string word)
            {
                var node = root;
                foreach (var c in word)
                {
                    if (!node.Children.ContainsKey(c))
                    {
                        node.Children[c] = new Node();
                    }
                    node = node.Children[c];
                }
                node.Value = word;
            }

            public bool Search(string word)
            {
                var node = root;
                foreach (var c in word)
                {
                    if (!node.Children.ContainsKey(c)) return false;
                    node = node.Children[c];
                }
                return node.Value == word;
            }

            public bool StartWith(string prefix)
            {
                var node = root;
                foreach (var c in prefix)
                {
                    if (!node.Children.ContainsKey(c)) return false;
                    node = node.Children[c];
                }
                return true;
            }
        }
    }
}