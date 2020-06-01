public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        var n = position.Length;
        var posToTime = new double[n][];
        for(var i = 0; i < n; ++i){
            posToTime[i] = new double[2];
            posToTime[i][0] = position[i];
            posToTime[i][1] = 1.0*(target - position[i])/speed[i]; 
        }
        Array.Sort(posToTime, (a,b)=>(int)(a[0]-b[0]));
        int ans = 0;
        double cur = 0;
        for(var i = n-1; i >= 0; --i){
            if(posToTime[i][1] > cur) {
                cur = posToTime[i][1];
                ans++;
            }
        }
        
        return ans;
    }
}