public class Solution {
    public int MirrorReflection(int p, int q) {
        var gcd = GCD(p, q);
        //least common multiple
        var lcm = q*p/gcd;
        var qcnt = lcm/q;
        var pcnt = lcm/p;
        
        if(qcnt%2 == 1){
            if(pcnt %2 == 1) return 1;
            else return 0;
        }
        else{
            //as the problem gauranteed the ray will meet a receptor, on the left side there is only receptor 2;
            return 2;
        }
    }
    
    int GCD(int a, int b){
        if(a == 0 || b == 0) return Math.Abs(a+b);
        return GCD(b, a%b);
    }
}