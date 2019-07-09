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
        //interative BFS
        var q1 = new Queue<TrieNode<string>>(); // for current trie node
        var q2 = new Queue<string>(); // for the word
        var q3 = new Queue<int>(); // for the index
        q1.Enqueue(root);
        q2.Enqueue(word);
        q3.Enqueue(0);
        
        while(q1.Count > 0){
            var trieNode = q1.Dequeue();
            var curWord = q2.Dequeue();
            var index = q3.Dequeue();
            if(index == curWord.Length)
                return false;
            if(curWord[index] == '.'){
                foreach(var key in trieNode.children.Keys){
                    if(index == curWord.Length - 1 && !string.IsNullOrEmpty(trieNode.children[key].val)) return true;
                    var newword = curWord.Substring(0, index) + key + curWord.Substring(index + 1);
                    q1.Enqueue(trieNode.children[key]);
                    q2.Enqueue(newword);
                    q3.Enqueue(index + 1);
                }    
            }
            else{
                if(!trieNode.children.ContainsKey(curWord[index]))
                    continue;
                if(trieNode.children[curWord[index]].val == curWord)
                    return true;
                q1.Enqueue(trieNode.children[curWord[index]]);
                q2.Enqueue(curWord);
                q3.Enqueue(index + 1);
            }
        }
        return false;
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */