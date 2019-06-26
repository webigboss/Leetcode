public class Solution {
    public int MaxProduct(string[] words) {
        var result = 0;
        var bitOps = new int[words.Length];
        for(var i = 0; i < words.Length; i++){
            foreach(var c in words[i]){
                bitOps[i] |=  1 << c - 'a'; 
            }
        }
        
        for(var i = 0; i < words.Length; i++){
            for(var j = i + 1; j < words.Length; j++){
                if((bitOps[i] & bitOps[j]) == 0)
                    result = Math.Max(result, words[i].Length * words[j].Length);
            }
        }
        return result;
    }
}