public class Solution {
    public int MagicalString(int n) {
        if(n == 0) return 0;
        var count = 1;
        if(n <= 3) return count;
        var s = new int[n];
        s[0] = 1;
        s[1] = 2;
        s[2] = 2;
        var lo = 2;
        var hi = 3;
        var step = 0;
        var curNum = 1;
        while(true){
            step = s[lo++];
            while(step > 0){
                s[hi++] = curNum;
                if(curNum == 1) count++;
                step--;
                if(hi == n) return count;
            }
            curNum ^= 3;
        }
        return count;
    }
}