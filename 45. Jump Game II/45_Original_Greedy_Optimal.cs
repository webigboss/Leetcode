public class Solution {
    //https://leetcode.com/problems/jump-game-ii/discuss/18014/Concise-O(n)-one-loop-JAVA-solution-based-on-Greedy
    //The main idea is based on greedy. Let's say the range of the current jump is [curBegin, curEnd], 
    //curFarthest is the farthest point that all points in [curBegin, curEnd] can reach. 
    //Once the current point reaches curEnd, then trigger another jump, and set the new curEnd with curFarthest, then keep the above steps, as the following:
    public int Jump(int[] nums) {
     	int jumps = 0, curEnd = 0, curFarthest = 0;
            for (int i = 0; i < nums.Length - 1; i++) {
                curFarthest = Math.Max(curFarthest, i + nums[i]);
                if (i == curEnd) {
                    jumps++;
                    curEnd = curFarthest;
            }
	    }
	    return jumps;
    }
}