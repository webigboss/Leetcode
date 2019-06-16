public class Solution {
    public bool WordPattern(string pattern, string str) {
        var dict = new Dictionary<char, string>();
        var dict2 = new Dictionary<string, char>();
        var arrStr = str.Trim().Split(' ');
        if(pattern.Length != arrStr.Length)
            return false;
        for(var i = 0; i < pattern.Length; i++){
            if(!dict.ContainsKey(pattern[i]))
                dict[pattern[i]] = arrStr[i];
            else{
                if(dict[pattern[i]] != arrStr[i])
                    return false;
            }
            
            if(!dict2.ContainsKey(arrStr[i]))
                dict2[arrStr[i]] = pattern[i];
            else{
                if(dict2[arrStr[i]] != pattern[i])
                    return false;
            }
        }
        return true;
    }
}