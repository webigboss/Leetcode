public class Solution {
    public bool IsPerfectSquare(int num) {
        //binary search approach
        if(num == 1) return true;
        long root = 1;
        long factor = 1;
        while((root + factor) * (root + factor) <= num){
            if((root + factor) * (root + factor) == num)
                return true;
            if((root + factor * 2) * (root + factor * 2) < num){
                factor *= 2;
            }
            else{
                root = root + factor;
                factor = 1;
            }
        }
        
        return false;
    }
}