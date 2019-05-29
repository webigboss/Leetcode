public class Solution {
    public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList) {
        var result = new List<IList<string>>();
        
        //dictionary holds all possible intermediate wildcards e.g. 'h*t'
        var dict = new Dictionary<string, List<string>>();
        //1. pre-processing wildcard dictionary
        foreach(var word in wordList){
            for(var i = 0; i < word.Length; i++){
                var wildcard = word.Substring(0, i) + '*' + word.Substring(i + 1, word.Length - 1 - i);
                if(dict.ContainsKey(wildcard))
                    dict[wildcard].Add(word);
                else
                    dict.Add(wildcard, new List<string>{ word });
            }
        }
        
        //2. BFS to get the minimum length, use it to optimize backtracking exit condition        
        var minLength = 0;
        var q = new Queue<string>();
        var distanceDict = new Dictionary<string, int>();//also used to memorize visited vertices
        q.Enqueue(beginWord);
        distanceDict.Add(beginWord, 1);
        var length = 0;
        while(q.Count > 0){
            var word = q.Dequeue();
            length = distanceDict[word];
            for(var i = 0; i < word.Length; i++){
                var wildcard = word.Substring(0, i) + "*" + word.Substring(i + 1, word.Length - 1 - i);
                if(dict.ContainsKey(wildcard)){
                    foreach(var next in dict[wildcard]){
                        if(distanceDict.ContainsKey(next))
                            continue;
                        distanceDict.Add(next, length + 1);
                        if(next == endWord)
                            break;
                        q.Enqueue(next);
                    }
                }
            }
        }
        
        //3. backtracking (essenstioanlly DFS to exhausting all non-directed graph traversal solutions, 
        //whereas stack implementation is just for getting one valid solution)
        //use the distanceDict to force the backtracking follows the BFS solution's order, brilliant!
        var list = new List<string>{ beginWord };
        BacktrackingHelper(beginWord, endWord, list, distanceDict, dict, result);
        return result;
    }
    
    private void BacktrackingHelper(string word, string endWord, IList<string> list, Dictionary<string, int> distanceDict,
                                    Dictionary<string, List<string>> dict, IList<IList<string>> result){
        if(word == endWord){
            result.Add(new List<string>(list));
            return;
        }
        for(var i = 0; i < word.Length; i++){
            var wildcard = word.Substring(0, i) + "*" + word.Substring(i + 1, word.Length - 1 - i);
            if(dict.ContainsKey(wildcard)){
                foreach(var next in dict[wildcard]){
                    if(distanceDict[word] + 1 != distanceDict[next])
                        continue;
                    list.Add(next);
                    BacktrackingHelper(next, endWord, list, distanceDict, dict, result);
                    list.RemoveAt(list.Count - 1);
                    
                }
            }
        }  
    }
}