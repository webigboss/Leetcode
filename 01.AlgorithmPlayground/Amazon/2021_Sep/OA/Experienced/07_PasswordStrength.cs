using System;
using System.Collections.Generic;
using System.Text;

//a substring that contain a vowel and consonant character can get 1 strength
// https://leetcode.com/discuss/interview-question/1471459/Amazon-OA/1089551
public class AmazonOA_07_PasswordStrength{
    public void Test(){
        string password;
        password = "hackerrank";
        Console.WriteLine($"{password} -> {PasswordStrength(password)}");
        password = "aaabaab";
        Console.WriteLine($"{password} -> {PasswordStrength(password)}");
        password = "baab";
        Console.WriteLine($"{password} -> {PasswordStrength(password)}");
        password = "ba";
        Console.WriteLine($"{password} -> {PasswordStrength(password)}");
        password = "aa";
        Console.WriteLine($"{password} -> {PasswordStrength(password)}");
        password = "thisisbeautiful"; // expected 6
        Console.WriteLine($"{password} -> {PasswordStrength(password)}");
        
    }

    public int PasswordStrength(string password){
        int ans = 0, n = password.Length;
        bool fndV = false, fndC = false;
        // password = hackerrank, n = 10;
        for(var i = 0; i < n; ++i) {
            // i = 4, 
            // fndC = f
            // fndV = f
            // ans = 2
            if(IsVowel(password[i])){
                fndV = true;
            }
            else{
                fndC = true;
            }

            if(fndV && fndC){
                ans++;
                fndV = false;
                fndC = false;
            }
        }
        return ans;
    }

    HashSet<char> vowels = new HashSet<char>(){'a','e','i','o','u', 'A','E','I','O','U'};
    private bool IsVowel(char c){
        return vowels.Contains(c);
    }
}