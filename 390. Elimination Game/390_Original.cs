public class Solution {
    public int LastRemaining(int n) {
        //https://leetcode.com/problems/elimination-game/discuss/87119/JAVA%3A-Easiest-solution-O(logN)-with-explanation
        //When will head be updated?
        // if we move from left
        // if we move from right and the total remaining number % 2 == 1
        // like 2 4 6 8 10, we move from 10, we will take out 10, 6 and 2, head is deleted and move to 4
        // like 2 4 6 8 10 12, we move from 12, we will take out 12, 8, 4, head is still remaining 2
        
        var head = 1; 
        bool isFromLeft = true;
        int remaining = n;
        int step = 1;
        
        //if remaining == 1, then next head is the answer
        while(remaining > 1) {
            if(isFromLeft || remaining % 2 == 1)
                head += step;
            remaining /= 2;
            step *= 2;
            isFromLeft = !isFromLeft;
        }
        return head;
    }
}