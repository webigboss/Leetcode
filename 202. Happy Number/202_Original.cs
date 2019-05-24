public class Solution {
    public bool IsHappy(int n) {
        var hs = new HashSet<int>();
        int temp = 0;
        while(true){
            if(n == 1)
                return true;
            if(hs.Contains(n))
                break;
            hs.Add(n);
            while(n != 0){
                temp += (int)Math.Pow(n % 10, 2);
                n /= 10;
            }
            n = temp;
            temp = 0;
        }
        return false;
    }
}