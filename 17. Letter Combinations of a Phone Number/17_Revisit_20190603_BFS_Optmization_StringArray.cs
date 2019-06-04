public class Solution {
    private Hashtable ht;
    public IList<string> LetterCombinations(string digits) {
        //BFS solution
        var i = 0;
        var result = new List<string>();
        if(string.IsNullOrEmpty(digits))
            return result;
        var arr = new []{ null, null, "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" }; 
            
        var q = new Queue<string>();
        q.Enqueue(string.Empty);
        while(q.Count > 0){
            var cur = q.Dequeue();
            if(cur.Length == digits.Length)
                result.Add(cur);
            else{
                foreach(var c in arr[digits[cur.Length] - '0'])
                    q.Enqueue(cur + c);
            }
        }
        
        return result;
    }
    

}