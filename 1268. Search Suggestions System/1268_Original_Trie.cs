public class Solution {
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord) {
        var result = new List<IList<string>>();
        var trie = new Trie();
        foreach(var p in products)
            trie.Insert(p);
        var sb = new StringBuilder();
        for(var i = 0; i < searchWord.Length; i++){
            sb.Append(searchWord[i]);
            var list = trie.SearchByPrefix(sb.ToString());
            if(list.Count > 3)
                list = list.GetRange(0, 3);
            result.Add(list);
        }
        return result;
    }
    
    public class Trie{
        private TrieNode _root;
        public Trie(){
            _root = new TrieNode();
        }
        
        public void Insert(string s){
            var node = _root;
            foreach(var c in s){
                if(!node.Children.ContainsKey(c))
                    node.Children[c] = new TrieNode();
                node = node.Children[c];
            }
            node.Value = s;
        }
        
        public bool StartWith(string prefix){
            var node = _root;
            foreach(var c in prefix){
                if(!node.Children.ContainsKey(c)) return false;
                node = node.Children[c];
            }
            return true;
        }
        
        public bool Search(string s){
            var node = _root;
            foreach(var c in s){
                if(!node.Children.ContainsKey(c)) return false;
                node = node.Children[c];
            }
            return node.Value == s;
        }
        
        public List<string> SearchByPrefix(string prefix){
            var result = new List<string>();
            var node = _root;
            foreach(var c in prefix){
                if(!node.Children.ContainsKey(c)) return result;
                node = node.Children[c];
            }
            Helper(node, result);
            result.Sort((a, b) => a.CompareTo(b));
            return result;
        }
        
        private void Helper(TrieNode node, IList<string> list){
            if(!string.IsNullOrEmpty(node.Value))
                list.Add(node.Value);
            foreach(var child in node.Children.Values){
                Helper(child, list);
            }
        }
         
    }
    
    public class TrieNode{
        public string Value { get; set;}
        public Dictionary<char, TrieNode> Children { get; set;}
        public TrieNode(){
            Children = new Dictionary<char, TrieNode>();
        }
    }
}