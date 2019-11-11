public class Solution {
    public int ArrangeCoins(int n) {
        // formula for calculating the sum of a arithmatic sequence
        // sum = (start+end)*count/2
        var i = Math.Ceiling(Math.Sqrt(n) * Math.Sqrt(2));
        while(true){
            if((1 + i) * i / 2 > n)
                i--;
            else
                break;
        }
        return (int)i;
    }
}