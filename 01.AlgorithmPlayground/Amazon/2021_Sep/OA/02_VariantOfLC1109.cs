using System;
using System.Collections.Generic;


public class FlightsBooking{

    public int[] CorpFlightBookings(int[][] bookings, int n) {
        //prefix sum
        var ans = new int[n];
        foreach(var b in bookings) {
            ans[b[0]-1] += b[2];
            if(b[1] == n) continue;
            ans[b[1]] -= b[2];
        }
        
        for(var i = 1; i < n; ++i){
            ans[i] += ans[i-1];
        }
        return ans;
    }
}