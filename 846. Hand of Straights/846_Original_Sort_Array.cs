public class Solution {
    public bool IsNStraightHand(int[] hand, int W) {
        var n = hand.Length;
        if(n%W != 0) return false;
        Array.Sort(hand);
        var used = new bool[n];
        int j = 0, prev = -1, cnt = 0;
        for(var i = 0; i < hand.Length; ++i){
            if(used[i])
                continue;
            j = i;
            prev = -1;
            
            while(true){
                if(cnt == W){
                    cnt = 0;
                    j = i;
                    break;
                }
                if(j == n && cnt != 0) {
                    return false;
                }
                if(used[j] || !used[j] && hand[j] == prev) {
                    j++;
                    continue;
                }
                
                if(prev != -1 && hand[j] != prev + 1)
                    return false;
                
                prev = hand[j];
                used[j++] = true;
                cnt++;
            }
        }
        return cnt == 0;
    }
}