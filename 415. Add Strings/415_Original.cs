public class Solution {
    public string AddStrings(string num1, string num2) {
        var length = Math.Max(num1.Length, num2.Length);
        num1 = num1.PadLeft(length, '0');
        num2 = num2.PadLeft(length, '0');
        int remainder,sum;
        int advance = 0;
        string result = string.Empty;
        for(var i = length - 1; i >= 0; i--){
            sum = num1[i] - '0' + num2[i] - '0' + advance;
            remainder = sum % 10;
            advance = sum / 10;
            result = remainder.ToString() + result;
        }
        if(advance != 0)
            result = advance.ToString() + result;
        return result;
    }
}