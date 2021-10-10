using System;
using System.Collections.Generic;

public class Google_FR_LargestPalindromicNumberAfterChange {
    public void Test() {
        string num;
        int k;
        num = "1231";
        k = 3;
        Console.WriteLine($"num: \"{num}\", k: {k} -> {LargestPalindromicNumberAfterChange(num, k)}");
        num = "12121";
        k = 3;
        Console.WriteLine($"num: \"{num}\", k: {k} -> {LargestPalindromicNumberAfterChange(num, k)}");
    }

    // num = "1231", k = 3
    // expected ans: "9339"
    public string LargestPalindromicNumberAfterChange(string num, int k) {
        var arr = num.ToCharArray();
        int n = num.Length, l = 0, r = n-1;

        while(l <= r && k > 0) {
            if(l == r){
                arr[l] = '9';
                break;
            }
            int nl = (int)(arr[l] - '0'), nr = (int)(arr[r] - '0');

            if(k >= 2) {
                if(nl != 9){
                    arr[l] = '9';
                }
                k--;
                if(nr != 9){
                    arr[r] = '9';
                }
                k--;
            }
            else if(k == 1) {
                if(nl != nr) {
                    var max = Math.Max(nl, nr);
                    arr[l] = (char)('0' + max);
                    arr[r] = arr[l];
                    k--;
                }
            }
            l++;
            r--;
        }
        return new string(arr);
    }
}