/**
 * The Rand7() API is already defined in the parent class SolBase.
 * public int Rand7();
 * @return a random integer in the range 1 to 7
 */
public class Solution : SolBase {
    public int Rand10() {
        var r2 = RandOutOf7(2);
        var r5 = RandOutOf7(5);
        if(r2 == 1) 
            return r5;
        else
            return 5 + r5;
    }
    
    private int RandOutOf7(int x){
        int r = Rand7();
        while(true) {
            if(r <= x) break;
            r = Rand7();
        }
        return r;
    }
    
}