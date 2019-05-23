public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        if(!wordList.Contains(endWord))
            return 0;
        var l = beginWord.Length;
        var dict = new Dictionary<string, List<string>>();
        
        //pre-processing
        foreach(var word in wordList){
            var list = new List<string>();
            for(var i = 0; i < l; i++){
                var key = word.Substring(0, i) + "*" + word.Substring(i + 1, l - 1 - i);
                if(dict.ContainsKey(key))
                    dict[key].Add(word);
                else
                    dict.Add(key, new List<string> { word } );
            }
        }
        
        //breadth first search for graph
        var htvisited = new Hashtable();
        var q = new Queue<KeyValuePair<string, int>>();
        q.Enqueue(new KeyValuePair<string, int>(beginWord, 1));

        while(q.Count > 0){
            var kvp = q.Dequeue();
            if(htvisited.ContainsKey(kvp.Key))
                continue;
            else
                htvisited.Add(kvp.Key, null);
            
            for(var i = 0; i < l; i++){
                var key = kvp.Key.Substring(0, i) + "*" + kvp.Key.Substring(i + 1, l - 1 - i);
                
                if(dict.ContainsKey(key)){
                    // found adjacent vertices
                    foreach(var adj in dict[key]){
                        if(adj == endWord)
                            return kvp.Value + 1;
                        q.Enqueue(new KeyValuePair<string, int>(adj, kvp.Value + 1));
                    }
                }
            }    
        }
        return 0;
    }
}