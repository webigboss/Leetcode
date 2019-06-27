public class Solution {
    public bool IsPowerOfFour(int num) {
        //base conversion approach
            if (num <= 0)
                return false;
            if (num == 1)
                return true;
            var sb = new StringBuilder();
            var pow = 0;
            while (num > 0)
            {
                sb.Append(num % 4);
                num /= 4;
            }
            var strNum = sb.ToString();
            if (strNum.Length == 1)
                return false;
            for (var i = strNum.Length - 1; i >= 0; i--)
            {
                if (i == strNum.Length - 1 && strNum[i] != '1')
                    return false;
                if (i != strNum.Length - 1 && strNum[i] != '0')
                    return false;
            }
            return true;
    }
}