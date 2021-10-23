using System;
using System.Collections.Generic;

public class Expedia_VO_01_IsPrime {
    public void Test(){
        int num;
        num = 1;
        Console.WriteLine($"IsPrime({num}) -> {IsPrime(num)}");
        num = 2;
        Console.WriteLine($"IsPrime({num}) -> {IsPrime(num)}");
        num = 3;
        Console.WriteLine($"IsPrime({num}) -> {IsPrime(num)}");
        num = 4;
        Console.WriteLine($"IsPrime({num}) -> {IsPrime(num)}");
        num = 7;
        Console.WriteLine($"IsPrime({num}) -> {IsPrime(num)}");
        num = 11;
        Console.WriteLine($"IsPrime({num}) -> {IsPrime(num)}");
        num = 12;
        Console.WriteLine($"IsPrime({num}) -> {IsPrime(num)}");
        num = 13;
        Console.WriteLine($"IsPrime({num}) -> {IsPrime(num)}");
        num = 17;
        Console.WriteLine($"IsPrime({num}) -> {IsPrime(num)}");
        num = 18;
        Console.WriteLine($"IsPrime({num}) -> {IsPrime(num)}");
        num = 29;
        Console.WriteLine($"IsPrime({num}) -> {IsPrime(num)}");
        num = 37;
        Console.WriteLine($"IsPrime({num}) -> {IsPrime(num)}");
        num = 78;
        Console.WriteLine($"IsPrime({num}) -> {IsPrime(num)}");
        num = 79;
        Console.WriteLine($"IsPrime({num}) -> {IsPrime(num)}");
    }

    public bool IsPrime(int num) {
        if(num <= 1)
            return false;
        // if(num == 2 || num == 3)
        //     return true;
        for(var i = 2; i*i <= num; i++) {
            if(num%i == 0)
                return false;
        }
        return true;
    }
}