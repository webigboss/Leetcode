public class Solution {
    public int UniqueMorseRepresentations(string[] words) {
        var codes = new string[]{".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
        var hs = new HashSet<string>();
        var sb = new StringBuilder();
        foreach(var w in words){
            sb.Clear();
            foreach(var c in w){
                sb.Append(codes[c-'a']);
            }
            hs.Add(sb.ToString());
        }
        return hs.Count;
    }
}