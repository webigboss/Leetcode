using System;
using System.Collections.Generic;

//https://www.1point3acres.com/bbs/thread-804217-1-1.html 
// distribut the int array packetes into cntOfChannels numbers of channels
// each channel should have at least one packet
// the quality of each channel is the median of the packets it has
// for even number of packets, the median is the avg of middle 2 packets, then round to next integer
public class AmazonOA_15_FindMaximumTransferQuality {
    public void Test(){
        int[] packets; int cntOfChannels;
        packets = new int[]{1,4,6,2,8,10,13,18};
        cntOfChannels = 4;
        Console.WriteLine($"[{string.Join(',',packets)}], cnt:{cntOfChannels} -> {MaxTransferQuality(packets, cntOfChannels)}");

    }

    public int MaxTransferQuality(int[] packets, int cntOfChannels) {
        int ans = 0, idx = packets.Length-1;
        Array.Sort(packets);
        while(cntOfChannels > 1){
            ans += packets[idx--];
            cntOfChannels--;
        }
        if(idx%2 == 0)
            ans += packets[idx/2];
        else{
            decimal avg = (packets[(idx+1)/2] + packets[(idx-1)/2])/2;
            ans += (int)Math.Ceiling(avg);
        }
        return ans;
    }
}