using System;
using System.Collections.Generic;

//https://leetcode.com/problems/flip-string-to-monotone-increasing/
public class AmazonOA_MinimumCoinFlips {

    public void Test(){
        var s = "THHHTH";
        Console.WriteLine($"MinimumCoinFlips({s}) -> {GetMinimumCoinFlips(s)}");
        s = "HHTHTT";
        Console.WriteLine($"MinimumCoinFlips({s}) -> {GetMinimumCoinFlips(s)}");
        s = "TTTTTTH";
        Console.WriteLine($"MinimumCoinFlips({s}) -> {GetMinimumCoinFlips(s)}");
        
    }
    public int GetMinimumCoinFlips(string s){
        int n = s.Length;
        int[] l = new int[n+1], r = new int[n+1];

        for (int i = 1, j = n-1; i <= n; i++, j--) {
            l[i] = l[i-1] + (s[i-1] == 'T' ? 1:0);
            r[j] = r[j+1] + (s[j] == 'H' ? 1:0);
        }
        int ans = n;
        for(var i = 0; i <= n; ++i){
            ans = Math.Min(ans, l[i] + r[i]);
        }
        return ans;
    }
}