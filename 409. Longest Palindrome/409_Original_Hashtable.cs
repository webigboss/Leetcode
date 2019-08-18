public class Solution {
    public int LongestPalindrome(string s) {
        //hash table approach
        var dict = new Dictionary<char, int>();
        foreach(var c in s){
            if(!dict.ContainsKey(c))
                dict[c] = 1;
            else
                dict[c]++;
        }
        
        var result = 0;
        var oddSelected = false;
        foreach(var kvp in dict){
            if(kvp.Value % 2 == 0)
                result += kvp.Value;
            else{
                if(!oddSelected){
                    result += kvp.Value;
                    oddSelected = true;
                }
                else
                    result += kvp.Value - 1;
            }
        }
        return result;
    }
}