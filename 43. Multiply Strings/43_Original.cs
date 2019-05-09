public class Solution {
    public string Multiply(string num1, string num2) {
        //inspired by the top vote answer
        var resultArray = new int[num1.Length + num2.Length];
        int left = 0;
        int right = 0;
        int sum = 0;
        for(var i = num1.Length - 1; i >= 0; i--){
            for(var j = num2.Length - 1; j >= 0; j--){
                sum = (num1[i] - '0') * (num2[j] - '0');
                left = i + j;
                right = i + j + 1;
                sum += resultArray[right];
                resultArray[left] += sum / 10;
                resultArray[right] = sum % 10;
            }
        }
        
        var sb = new StringBuilder();
        var isHeadingZero = true;
        foreach(var i in resultArray){
            if(i == 0 && isHeadingZero){
                continue;
            }
            if(i != 0)
                isHeadingZero = false;
            sb.Append(i);
        }
        
        return (sb.Length == 0) ? "0" : sb.ToString();
    }
}