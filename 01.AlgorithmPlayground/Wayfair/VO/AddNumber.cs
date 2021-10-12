using System;
using System.Collections.Generic;
using System.Text;

public class Wayfare_VO_AddNumbers {
    public void Test(){
        string a, b;
        a = "1";
        b = "9999";
        Console.WriteLine($"AddNumbers({a},{b}) -> {AddNumbers(a, b)}");
        a = "1111";
        b = "9999";
        Console.WriteLine($"AddNumbers({a},{b}) -> {AddNumbers(a, b)}");
        a = "1";
        b = "9,999";
        Console.WriteLine($"AddNumbersWithSeperator(\"{a}\" \"{b}\") -> {AddNumbersWithSeperator(a, b)}");
        a = "1,111";
        b = "9,999";
        Console.WriteLine($"AddNumbersWithSeperator(\"{a}\" \"{b}\") -> {AddNumbersWithSeperator(a, b)}");
        a = "1";
        b = "99,999";
        Console.WriteLine($"AddNumbersWithSeperator(\"{a}\" \"{b}\") -> {AddNumbersWithSeperator(a, b)}");
        a = "1";
        b = "999,999";
        Console.WriteLine($"AddNumbersWithSeperator(\"{a}\" \"{b}\") -> {AddNumbersWithSeperator(a, b)}");
        int n = 100;
        var fibonacciNumbers = CalculatingFibunacciSequence(n);
        PrintFibonacciNumbersLineByLine(fibonacciNumbers);
    }


    public string AddNumbers(string a, string b) {
        int i = a.Length-1, j = b.Length-1, cur = 0, adv = 0;
        var ans = new List<char>();
        while(i >= 0 || j >= 0) {
            if(i < 0){
                cur = b[j] - '0' + adv;
                j--;
            }
            else if(j < 0) {
                cur = a[i] - '0' + adv;
                i--;
            }
            else {
                cur = (a[i] - '0') + (b[j] - '0') + adv;
                j--; i--;
            }
            adv = cur / 10;
            ans.Add((char)('0' + cur % 10));
        }
        if(adv > 0){
            ans.Add((char)('0' + adv));
        }
        ans.Reverse();
        return new string(ans.ToArray());
    }

    public string AddNumbersWithSeperator(string a, string b){
        int i = a.Length-1, j = b.Length-1, cur = 0, adv = 0;
        var st = new Stack<char>();
        while(i >= 0 || j >= 0) {
            if(i > 0 && a[i] == ','){
                i--;
                continue;
            }
            if(j > 0 && b[j] == ','){
                j--;
                continue;
            }
            if(i < 0){
                cur = b[j--] - '0' + adv;
            }
            else if(j < 0) {
                cur = a[i--] - '0' + adv;
            }
            else {
                cur = a[i--] - '0' + b[j--] - '0' + adv;
            }
            adv = cur / 10;
            st.Push((char)('0' + cur % 10));
        }
        if(adv > 0)
            st.Push((char)('0' + adv));
        int counter = st.Count % 3;
        var sb = new StringBuilder();
        while(st.Count > 0) {
            if(counter == 0){
                counter = 3;
                if(sb.Length > 0)
                    sb.Append(',');
                continue;
            }
            sb.Append(st.Pop());
            counter--;
        }
        return sb.ToString();
    }

    public List<string> CalculatingFibunacciSequence(int n){
        var ans = new List<string>();
        string a = "1", b = "1";
        ans.Add(a);
        ans.Add(b);
        n -= 2;
        while(n > 0){
            ans.Add(AddNumbersWithSeperator(ans[ans.Count-1], ans[ans.Count-2]));
            n--;
        }
        return ans;
    }

    private void PrintFibonacciNumbersLineByLine(List<string> fNumbers){
        Console.WriteLine($"CalculatingFibunacciSequence({fNumbers.Count}) ->");
        foreach(var num in fNumbers)
            Console.WriteLine(num);
    }
}