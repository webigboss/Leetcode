public class Solution {
    class TrieNode{
        public string val;
        public Dictionary<char, TrieNode> children;
        public TrieNode(){
            children = new Dictionary<char, TrieNode>();
        }
    }
    
    void Add(string word){
        var node = root;
        for(var i = word.Length-1; i >= 0; --i){
            if(!node.children.ContainsKey(word[i]))
                node.children[word[i]] = new TrieNode();
            node = node.children[word[i]];
        }
        node.val = word;
    }
    
    int GetLength(TrieNode node){
        var ans = 0;
        
        if(node.children.Any()){
            foreach(var childNode in node.children.Values){
                ans += GetLength(childNode);
            }
        }
        else{
            ans = node.val.Length+1;
        }
        return ans;
    }
    
    TrieNode root;
    public int MinimumLengthEncoding(string[] words) {
        root = new TrieNode();
        foreach(var w in words)
            Add(w);
        return GetLength(root);
    }
}