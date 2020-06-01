public class Solution {
    public int MaxDistToClosest(int[] seats) {
        int iprev = -1, ans = 0;
        
        for(var i = 0; i < seats.Length; ++i){
            if(seats[i] == 1){
                if(iprev == -1) ans = i;
                else ans = Math.Max(ans, (i-iprev)/2);
                iprev = i;
            }
            else{
                if(i == seats.Length-1) ans = Math.Max(ans, i-iprev);
            }
        }
        return ans;
    }
}