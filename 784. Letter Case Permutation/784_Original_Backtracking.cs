public class Solution {
    public IList<string> LetterCasePermutation(string S) {
        //backtracking
        S = S.ToLower();
        var result = new List<string>();
        Helper(S, 0, result);
        return result;
    }
    
    private void Helper(string s, int index, IList<string> result){
        if(index == s.Length) {
            result.Add(s);
            return;
        }
        
        if(Char.IsDigit(s[index])){
            Helper(s, index+1, result);
        }
        else{
            Helper(s, index+1, result);
            if(s[index] >= 65 && s[index] <= 90){
                var cur = s.Substring(0, index) + (char)(s[index]+32) + s.Substring(index+1, s.Length-index-1);
                Helper(cur, index+1, result);
            }
            else{
                var cur = s.Substring(0, index) + (char)(s[index]-32) + s.Substring(index+1, s.Length-index-1);
                Helper(cur, index+1, result);
            }
        } 
    }
}