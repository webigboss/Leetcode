public class Solution {
    public int IsPrefixOfWord(string sentence, string searchWord) {
        var arr = sentence.Split(' ');
        for(var i = 0; i < arr.Length; ++i){
            if(arr[i].StartsWith(searchWord))
                return i+1;
        }
        return -1;
    }
}