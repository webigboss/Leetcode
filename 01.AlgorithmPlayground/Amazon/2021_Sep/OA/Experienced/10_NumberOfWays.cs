using System;
using System.Collections.Generic;
using System.Text;

public class AmazonOA_10_NumberOfWays {
    public void Test(){
        string book;
        book = "01001";
        Console.WriteLine($"NumberOfWays({book}) -> {NumberOfWays(book)}"); // expected ans: 4
        book = "10111";
        Console.WriteLine($"NumberOfWays({book}) -> {NumberOfWays(book)}"); // expected ans: 3
        book = "0001";
        Console.WriteLine($"NumberOfWays({book}) -> {NumberOfWays(book)}"); // expected ans: 0
        book = "01001000";
        Console.WriteLine($"NumberOfWays({book}) -> {NumberOfWays(book)}"); // expected ans: 16

    }

    public long NumberOfWays(string book) {
        long ans = 0;
        int n = book.Length;
        var sumZero = new int[n];
        var sumOne = new int[n];


        for(var i = 0; i < n; ++i){
            if(i > 0){
                sumOne[i] = sumOne[i-1];
                sumZero[i] = sumZero[i-1];
            }
            if(book[i] == '0')
                sumZero[i]++;
            else
                sumOne[i]++;
        }
        //01001
        //sumOne -> [0,1,1,1,2]
        //sumZero-> [1,1,2,3,3]
        Console.WriteLine($"sumOne -> [{string.Join(',',sumOne)}]");
        Console.WriteLine($"sumZero -> [{string.Join(',',sumZero)}]");
        for(var i = 1; i < n-1; ++i){//i = 1
            if(book[i] == '0'){
                ans += sumOne[i-1] * (sumOne[n-1]-sumOne[i]);
            }
            else {
                ans += sumZero[i-1] * (sumZero[n-1]-sumZero[i]);
            }
        }
        return ans;
    }
}