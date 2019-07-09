public class WordDictionary {
    internal class TrieNode<T>{
        public TrieNode(){
            children = new Dictionary<char, TrieNode<T>>();
        }
        public T val;
        public Dictionary<char, TrieNode<T>> children;
    }
    private TrieNode<string> root;
    /** Initialize your data structure here. */
    public WordDictionary() {
        root = new TrieNode<string>();
    }
    
    /** Adds a word into the data structure. */
    public void AddWord(string word) {
        var node = root;
        foreach(var c in word){
            if(!node.children.ContainsKey(c))
                node.children[c] = new TrieNode<string>();
            node = node.children[c];
        }
        node.val = word;
    }
    
    /** Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter. */
    public bool Search(string word) {
        var node = root;
        return SearchHelper(word, 0, node);
    }
    
    private bool SearchHelper(string word, int index, TrieNode<string> node){    
        if(index == word.Length) return false;
        if(word[index] == '.'){
            var result = false;
            foreach(var key in node.children.Keys){
                if(index == word.Length - 1 && !string.IsNullOrEmpty(node.children[key].val)) return true;
                var newword = word.Substring(0, index) + key + word.Substring(index + 1); 
                result = result || SearchHelper(newword, index + 1, node.children[key]);
            }
            return result;
        }
        else{
            if(!node.children.ContainsKey(word[index]))
                return false;
            if(node.children[word[index]].val == word)
                return true;
            if(index == word.Length - 1) return false;
            return SearchHelper(word, index + 1, node.children[word[index]]);
        }
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */