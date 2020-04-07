public class Solution {
    public bool CheckPerfectNumber(int num) {
        if(num == 1) return false;
        int sqrt = (int)Math.Pow(num, 0.5);
        var sum = 1;
        for(var i = 2; i <= sqrt; ++i){
            if(num % i == 0){
                sum += i;
                sum += num / i;
            }
        }
        return sum == num;
    }
}