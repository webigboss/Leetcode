public class Solution {
    public int PoorPigs(int buckets, int minutesToDie, int minutesToTest) {
        //https://leetcode.com/problems/poor-pigs/discuss/94273/Solution-with-detailed-explanation
        int rounds = minutesToTest / minutesToDie;
        return (int)Math.Ceiling(Math.Log(buckets, rounds + 1));
    }
}