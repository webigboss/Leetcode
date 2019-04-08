public class Solution {
    private Hashtable ht;
    public IList<string> LetterCombinations(string digits) {
        var i = 0;
        var result = new List<string>();
        ht = new Hashtable();
        ht.Add('2', new char[]{'a', 'b', 'c'});
        ht.Add('3', new char[]{'d', 'e', 'f'});
        ht.Add('4', new char[]{'g', 'h', 'i'});
        ht.Add('5', new char[]{'j', 'k', 'l'});
        ht.Add('6', new char[]{'m', 'n', 'o'});
        ht.Add('7', new char[]{'p', 'q', 'r', 's'});
        ht.Add('8', new char[]{'t', 'u', 'v'});
        ht.Add('9', new char[]{'w', 'x', 'y', 'z'});
	  LetterCombinationsHelper(string.Empty, digits, 0, result);
	  return result;
    }
    
    private void LetterCombinationsHelper(string cur, string digits, int i, List<string> result){
        if(i > digits.Length - 1)
            return;
        else if(i == digits.Length - 1){
        		foreach(var c in (char[])ht[digits[i]])
				result.Add(cur+c);
        }
        else{
            foreach(var c in (char[])ht[digits[i]]){
                    LetterCombinationsHelper(cur+c, digits, i+1, result);	
			}
        }
    }
}