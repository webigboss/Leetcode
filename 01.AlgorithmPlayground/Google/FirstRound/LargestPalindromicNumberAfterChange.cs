using System;
using System.Collections.Generic;

public class Google_FR_LargestPalindromicNumberAfterChange {
    public void Test() {

    }

    // num = "1231", k = 3
    // expected ans: "9339"
    public string LargestPalindromicNumberAfterChange(string num, int k) {
        var arr = num.ToCharArray();
        int n = num.Length, l = 0, r = n-1;

        while(l <= r) {
            if(l == r){

            }
            char cl = arr[l], cr = arr[r]; 
            int j = 2; // changes needed, initial value = 2, if cl or cr == 9, decrease it by 1 for each
            if(cl == '9')
                j--;
            if(cr == '9')
                j--;
            if(j == 0){
                l++;
                r--;
            }

        }
    }
}