using System.Collections.Generic;

namespace AlgorithmPlayground
{
    public class MagicDictionary
    {
        public class TrieNode
        {
            public string Val { get; set; }
            public Dictionary<char, TrieNode> Children { get; set; }
            public TrieNode()
            {
                Children = new Dictionary<char, TrieNode>();
            }
        }

        public class Trie
        {
            private TrieNode root;
            public Trie()
            {
                root = new TrieNode();
            }

            public void Insert(string s)
            {
                var node = root;
                foreach (var c in s)
                {
                    if (!node.Children.ContainsKey(c))
                    {
                        node.Children[c] = new TrieNode();
                    }
                    node = node.Children[c];
                }
                node.Val = s;
            }

            public bool SearchWithMod(string s, int mod)
            {
                return Helper(root, s, 0, 1);
            }

            private bool Helper(TrieNode node, string s, int index, int mod)
            {
                if (mod == 0 && node.Val == s)
                    return true;
                if (mod < 0 || index >= s.Length) return false;

                foreach (var kvp in node.Children)
                {
                    if (kvp.Key == s[index])
                    {
                        if (Helper(kvp.Value, s, index + 1, mod))
                            return true;
                    }
                    else
                    {
                        var arr = s.ToCharArray();
                        arr[index] = kvp.Key;
                        var newStr = new string(arr);
                        if (Helper(kvp.Value, newStr, index + 1, mod - 1))
                            return true;
                    }
                }


                return false;
            }
        }

        private Trie trie;
        /** Initialize your data structure here. */
        public MagicDictionary()
        {
            trie = new Trie();
        }

        /** Build a dictionary through a list of words */
        public void BuildDict(string[] dict)
        {
            foreach (var s in dict)
                trie.Insert(s);
        }

        /** Returns if there is any word in the trie that equals to the given word after modifying exactly one character */
        public bool Search(string word)
        {
            return trie.SearchWithMod(word, 1);
        }
    }

    /**
     * Your MagicDictionary object will be instantiated and called as such:
     * MagicDictionary obj = new MagicDictionary();
     * obj.BuildDict(dict);
     * bool param_2 = obj.Search(word);
     */
}