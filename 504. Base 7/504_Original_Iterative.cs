public class Solution {
    public string ConvertToBase7(int num) {
        if(num == 0) return "0";
        var isNegative = num < 0;
        num = Math.Abs(num);
        var result = string.Empty;
        while(num != 0){
            result = (num % 7).ToString() + result;
            num /= 7;
        }
        
        return isNegative ? '-' + result : result;
    }
}