public class Trie {
    protected class Node<T> {
        public Node(){
            children = new Dictionary<char, Node<T>>();
        }
        public T val;
        public Dictionary<char, Node<T>> children;
    }
    
    private Node<string> root;
    
    /** Initialize your data structure here. */
    public Trie() {
        root = new Node<string>();
    }
    
    /** Inserts a word into the trie. */
    public void Insert(string word) {
        var node = root;
        foreach(var c in word){
            if(!node.children.ContainsKey(c))
                node.children[c] = new Node<string>();
            node = node.children[c];
        }
        node.val = word;
    }
    
    /** Returns if the word is in the trie. */
    public bool Search(string word) {
        var node = root;
        foreach(var c in word){
            if(!node.children.ContainsKey(c))
                return false;
            node = node.children[c];
        }
        return node.val == word;
    }
    
    /** Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith(string prefix) {
        var node = root;
        foreach(var c in prefix){
            if(!node.children.ContainsKey(c))
                return false;
            node = node.children[c];
        }
        return true;
    }
}


/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */