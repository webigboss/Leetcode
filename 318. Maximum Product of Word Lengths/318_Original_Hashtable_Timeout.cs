public class Solution {
    public int MaxProduct(string[] words) {
        var dict = new Dictionary<char, List<int>>();
        var result = 0;
        for(var i = 0; i < words.Length; i++){
            foreach(var c in words[i]){
                if(dict.ContainsKey(c))
                    dict[c].Add(i);
                else
                    dict[c] = new List<int> { i };
            }
        }
        
        for(var i = 0; i < words.Length; i++){
            var visited = new bool[words.Length];
            foreach(var c in words[i]){
                foreach(var index in dict[c])
                    visited[index] = true;
            }
            for(var j = 0; j < visited.Length; j++){
                if(!visited[j])
                    result = Math.Max(result, words[i].Length * words[j].Length);
            }
        }
        
        return result;
    }
}