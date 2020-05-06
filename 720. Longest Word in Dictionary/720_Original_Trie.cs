public class Solution {
    public class TrieNode{
        public string val;
        public Dictionary<char, TrieNode> children;
        public TrieNode(){
            children = new Dictionary<char, TrieNode>();
        }
    }
    private TrieNode root;
    public string LongestWord(string[] words) {
        root = new TrieNode();
        root.val = "z";
        foreach(var w in words)
            Add(w);
        var ans = string.Empty;
        ans = FindLongestWord(root);
        return ans;
    }
    
    private void Add(string word){
        var node = root;
        foreach(var c in word){
            if(!node.children.ContainsKey(c))
                node.children[c] = new TrieNode();
            node = node.children[c];
        }
        node.val = word;
    }
    
    private string FindLongestWord(TrieNode node) {
        if(node == null || string.IsNullOrEmpty(node.val)) return string.Empty;
        var ans = node.val;
        foreach(var c in node.children.Values) {
            var cword = FindLongestWord(c);
            if(cword.Length > ans.Length ||
              cword.Length == ans.Length && String.Compare(cword, ans) < 0)
                ans = cword;
        }
        return ans;
    }
}