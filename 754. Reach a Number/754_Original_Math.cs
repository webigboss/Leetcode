public class Solution {
    public int ReachNumber(int target) {
        var sum = 0;
        var n = 0;
        target = Math.Abs(target);
        while(sum < target){
            n++;
            sum += n;
        }
        
        var delta = sum - target;
        if(delta %2 ==0)
            return n;
        else{
            if(n%2 == 0)
                return n+1;
            else 
                return n+2;
        }
    }
}