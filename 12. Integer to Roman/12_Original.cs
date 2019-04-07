public class Solution {
    public string IntToRoman(int num) {
        var roman = string.Empty;
        while(num != 0){
            var i = (int)(num / Math.Pow(10, num.ToString().Length - 1));
            switch(num.ToString().Length)
            {
                case 4:
                    roman += new String('M', i);
                    break;
                case 3:
                    roman += RomanCreator(i, 'C', 'D', 'M');
                    break;
                case 2:
                    roman += RomanCreator(i, 'X', 'L', 'C');
                    break;
                case 1:
                    roman += RomanCreator(i, 'I', 'V', 'X');
                    break;
                default:
                    break;
            }
            num = num - i * (int)Math.Pow(10, num.ToString().Length - 1);
        }
        return roman;
    }
    
    private string RomanCreator(int i, char cone, char cfive, char cten){
        var sb = new StringBuilder();
        if(i < 4){
            sb.Append(new string(cone, i));
        }
        else if(i == 4){
            sb.Append(cone);
            sb.Append(cfive);
        }
        else if(i == 5)
            return new string(cfive, 1);
        else if(i > 5 && i < 9){
            sb.Append(cfive);
            sb.Append(new string(cone, i - 5));
        }
        else{
            // i == 9
            sb.Append(cone);
            sb.Append(cten);
        }
        return sb.ToString();
    }
}