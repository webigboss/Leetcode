/**
 * The Rand7() API is already defined in the parent class SolBase.
 * public int Rand7();
 * @return a random integer in the range 1 to 7
 */
public class Solution : SolBase {
    public int Rand10() {
        var r = 7 * (Rand7() - 1) + Rand7();
        while(true) {
            if(r <= 40) break;
            r = 7 * (Rand7() - 1) + Rand7();
        }
        return r % 10 + 1;
    }
}