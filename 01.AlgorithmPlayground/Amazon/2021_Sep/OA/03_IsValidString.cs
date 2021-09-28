using System;
using System.Collections.Generic;

public class AmazonOA_IsValidString {

    public void Test(){
        var s1 = "ABBACDDC";
        Console.WriteLine($"IsValidString({s1}) -> {IsValidString(s1)}");
        s1 = "AABBAA";
        Console.WriteLine($"IsValidString({s1}) -> {IsValidString(s1)}");
        s1 = "AABAA";
        Console.WriteLine($"IsValidString({s1}) -> {IsValidString(s1)}");
        s1 = "EABBACDDFFCE";
        Console.WriteLine($"IsValidString({s1}) -> {IsValidString(s1)}");
        
    }
    public bool IsValidString(string s){
        int n = s.Length;
        return DpTopdown(s, 0, n-1, new int[n,n]);
        
    }

    private bool DpTopdown(string s, int l, int r, int[,] memo) {
        Console.WriteLine($"DpTopdown([{l},{r}])");
        if(l == r || (r-l+1)%2 != 0){
            memo[l,r] = -1;
            return false;
        }
        if (l > r) {
            memo[l,r] = 1;
            return true;
        }
        if(memo[l,r] != 0)
            return memo[l,r] == 1? true : false;
        
        var ans = false;
        if(s[l] == s[r] && DpTopdown(s, l+1, r-1, memo)){
            memo[l,r] = 1;
            return true;
        }

        for(var m = l+1; m < r; m+=2){
            if(DpTopdown(s, l, m, memo) && DpTopdown(s, m+1, r, memo)){
                ans = true;
                break;
            }
        }
        memo[l,r] = ans ? 1 : -1;
        return ans;
    }
}