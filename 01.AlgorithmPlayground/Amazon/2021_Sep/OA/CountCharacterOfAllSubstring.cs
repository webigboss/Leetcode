using System;
using System.Collections.Generic;

//this is simplified version of LC 828
// https://leetcode.com/problems/count-unique-characters-of-all-substrings-of-a-given-string/

public class CountCharacterOfAllSubString{

    public void Test(){
        string s1 = "ABCB", s2 = "ABC", s3 = "ABA";
        GetCountOfCharacterOfAllSubstrings(s1);
        GetCountOfCharacterOfAllSubstrings(s2);
        GetCountOfCharacterOfAllSubstrings(s3);
        GetCountOfCharacterOfAllSubstringsSpaceOptimized(s1);
        GetCountOfCharacterOfAllSubstringsSpaceOptimized(s2);
        GetCountOfCharacterOfAllSubstringsSpaceOptimized(s3);
        
    }
    public int GetCountOfCharacterOfAllSubstrings(string s){ 
        // s = "ABCB"
        int ans = 0, n = s.Length; // n = 4
        var dp = new int[n]; // dp = [0, 0, 0, 0]
        dp[0] = 1;
        var lastPos = new int[26]; // lastPos = []
        Array.Fill(lastPos, -1);
        lastPos[(int)(s[0]-'A')] = 0;
        for(var i = 1; i < n; ++i){
            var idx = (int)(s[i]-'A');
            dp[i] = dp[i-1] + i-lastPos[idx];
            lastPos[idx] = i;
        }
        
        for(var i = 0; i < n; ++i){
            ans += dp[i];
        }
        Console.WriteLine($"GetCountOfCharacterOfAllSubstrings({s})->{ans}");
        return ans;
    }

    public int GetCountOfCharacterOfAllSubstringsSpaceOptimized(string s){
        // s = "ABCB"
        int ans = 0, curDp = 0, n = s.Length;
        var lastPos = new int[26];
        Array.Fill(lastPos, -1);
        for(var i = 0; i < n; ++i){
            var idx = (int)(s[i] - 'A'); // i = 2, S[i] = 'C', idx = 2
            curDp += i - lastPos[idx]; // curDp = 1 + 1-(-1) = 3
            lastPos[idx] = i; 
            ans += curDp; // ans = 4
        }
        Console.WriteLine($"GetCountOfCharacterOfAllSubstringsSpaceOptimized({s})->{ans}");
        return ans;
    }
}