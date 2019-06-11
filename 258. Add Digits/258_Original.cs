public class Solution {
    public int AddDigits(int num) {
        int result = 0;
        while(true){
            result = 0;
            while(num != 0){
                result += num % 10;
                num /= 10;
            }
            num = result;
            if(result < 10)
                break;
        }
        return result;
    }
}