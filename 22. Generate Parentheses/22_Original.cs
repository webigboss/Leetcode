public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        var result = new List<string>();
        GenerateParenthesisBacktracking(string.Empty, 0, 0, result, n);
        return result;
    }
    
    private void GenerateParenthesisBacktracking(string p, int open, int close, List<string> result, int count){
        if(p.Length == 2 * count)
            result.Add(p);
        
        if(open < count){
            // the way of appending parenthesis matters, cannot be "(" + p
            GenerateParenthesisBacktracking(p + "(", open + 1, close, result, count);
        }
        
        if(close < open){
            // the way of appending parenthesis matters
            GenerateParenthesisBacktracking(p + ")", open, close + 1, result, count);
        }
    }
}