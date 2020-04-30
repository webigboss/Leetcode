public class Solution {
    public bool CheckValidString(string s) {
        //official solution#2 greedy
        int hi = 0, lo = 0;
        foreach(var c in s){
            if(c == '(') 
                lo++;
            else 
                lo--;
            
            if(c ==')')
                hi--;
            else
                hi++;
            
            lo = Math.Max(0, lo);
            if(hi < 0)
                return false;
        }
        return lo == 0;
    }
}