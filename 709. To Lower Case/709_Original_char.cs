public class Solution {
    public string ToLowerCase(string str) {
        //a~z 97-122 A-Z 65-90
        var result = new char[str.Length];
        for(var i = 0; i < str.Length; i++)
            result[i] = str[i] >= 65 && str[i] <= 90 ? (char)(str[i] + 32) : str[i];    
        return new string(result);
    }
}