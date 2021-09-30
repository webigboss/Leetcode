using System;
using System.Collections.Generic;
using System.Text;

public class AmazonOA_08_MinimumAdjescentSwapToSortBinaryString {
    
    public void Test() {
        string s;
        s = "00010100";
        Console.WriteLine($"MinimumAdjescentSwapToSortBinaryString({s}) -> {MinimumAdjescentSwapToSortBinaryString(s)}");
        s = "000010100";
        Console.WriteLine($"MinimumAdjescentSwapToSortBinaryString({s}) -> {MinimumAdjescentSwapToSortBinaryString(s)}");
    }
    public int MinimumAdjescentSwapToSortBinaryString(string s) {
        int ans0, ans1;
        ans0 = SortToLeft(s, '0'); 
        ans1 = SortToLeft(s, '1'); // ans1 = 7
        return Math.Min(ans0, ans1);
    }

    private int SortToLeft(string s, char c) {
        int n = s.Length, idx = 0, ans = 0;
        // s = "00010100", c = '0'
        // idx = 5
        // ans = 1+2+2
        for(var i = 0; i < n; ++i){ // i = 7
            if(s[i] == c){
                ans += i-idx;
                idx++;
            }
        }
        return ans;
    }
}