public class Solution {
    public int RotatedDigits(int N) {
        var ans = 0;
        
        for(var i = 1; i <= N; ++i){
            var s = i.ToString();
            var isLegit = false;
            foreach(var c in s){
                if(c == '3' || c == '4' || c == '7'){
                    isLegit = false;
                    break;
                }
                else if(c == '2' || c =='5' || c == '6' || c == '9'){
                    isLegit = true;
                }
            }
            if(isLegit) ans++;
        }
        return ans;
    }
}