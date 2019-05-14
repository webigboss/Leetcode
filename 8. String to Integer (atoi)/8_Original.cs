public class Solution {
    public int MyAtoi(string str) {
        var sb = new StringBuilder();
        int isNegative = 1;
        
        var digitStarts = false;
        var digitEnds = false;
        var meetOperator = false;
        var isValid = true;
        for(var i = 0; i < str.Length; i++){
            if(digitEnds)
                break;
            if(str[i] == '+' || str[i] == '-'){
                if(digitStarts)
                    digitEnds = true;
                if(meetOperator == true)
                    continue;
                if(digitEnds || digitStarts || i == str.Length - 1 || !char.IsDigit(str[i + 1])){
                    isValid = false;
                    break;
                }
                if(str[i] == '-')
                    isNegative = -1;
                meetOperator = true;
            }
            else if(str[i] == ' '){
                if(digitStarts)
                    digitEnds = true;
                continue;
            }
            else if(char.IsDigit(str[i])){
                if(!digitEnds){                    
                    sb.Append(str[i]);
                    digitStarts = true;
                    meetOperator = true;
                }
                else
                    continue;
            }
            else{
                if(digitStarts)
                    digitEnds = true;
                else{
                    isValid = false;
                    break;
                }
                continue;
            }
        }
        if(!isValid)
            return 0;
        var strnumber = sb.ToString();
        if(string.IsNullOrEmpty(strnumber))
            return 0;
        int number;
        if(int.TryParse(strnumber, out number))
            return number * isNegative;
        else{
            if(isNegative == -1)
                return int.MinValue;
            else
                return int.MaxValue;
        }
    }
}