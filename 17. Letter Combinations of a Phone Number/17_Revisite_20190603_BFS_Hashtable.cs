public class Solution {
    private Hashtable ht;
    public IList<string> LetterCombinations(string digits) {
        var i = 0;
        var result = new List<string>();
        if(string.IsNullOrEmpty(digits))
            return result;
        var dict = new Dictionary<char, char[]>();
        dict.Add('2', new char[]{'a', 'b', 'c'});
        dict.Add('3', new char[]{'d', 'e', 'f'});
        dict.Add('4', new char[]{'g', 'h', 'i'});
        dict.Add('5', new char[]{'j', 'k', 'l'});
        dict.Add('6', new char[]{'m', 'n', 'o'});
        dict.Add('7', new char[]{'p', 'q', 'r', 's'});
        dict.Add('8', new char[]{'t', 'u', 'v'});
        dict.Add('9', new char[]{'w', 'x', 'y', 'z'});
	  
        var q = new Queue<string>();
        q.Enqueue(string.Empty);
        while(q.Count > 0){
            var cur = q.Dequeue();
            if(cur.Length == digits.Length)
                result.Add(cur);
            else{
                foreach(var c in dict[digits[cur.Length]])
                    q.Enqueue(cur + c);
            }
        }
        
        return result;
    }
    

}