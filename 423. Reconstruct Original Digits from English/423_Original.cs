public class Solution {
    public string OriginalDigits(string s) {
        //one, two, three, four, five, six, seven, eight, nine, zero
        //unique chars: z(zero), g(eight), u(four), w(two), x(six)
        //remove above numbers we get: one, three, five, seven, nine
        //remove in this order o(one), t(three), f(five), s(sevem), i(nine)
        //so finally a viable order would be: 
        //z(zero), g(eight), u(four), w(two), x(six), o(one), t(three), f(five), s(sevem), i(nine)
        var charCounts = new int[26];
        var numberCounts = new int[10];
        
        for(var i = 0; i < s.Length; i++){
            charCounts[s[i] - 'a']++;
        }
        
        var curCharCount = 0;
        //removing numbers in above orders
        //zero
        SubtractCharCount('z', "zero", 0, charCounts, numberCounts);
        //eight
        SubtractCharCount('g', "eight", 8, charCounts, numberCounts);
        //four
        SubtractCharCount('u', "four", 4, charCounts, numberCounts);
        //two
        SubtractCharCount('w', "two", 2, charCounts, numberCounts);
        //six
        SubtractCharCount('x', "six", 6, charCounts, numberCounts);
        //one
        SubtractCharCount('o', "one", 1, charCounts, numberCounts);
        //three
        SubtractCharCount('t', "three", 3, charCounts, numberCounts);
        //five
        SubtractCharCount('f', "five", 5, charCounts, numberCounts);
        //seven
        SubtractCharCount('s', "seven", 7, charCounts, numberCounts);
        //nine
        SubtractCharCount('i', "nine", 9, charCounts, numberCounts);
        
        var sb = new StringBuilder();
        for(var i = 0; i < numberCounts.Length; i++){
            sb.Append(new string(i.ToString()[0], numberCounts[i]));
        }
        return sb.ToString();
    }
    
    private void SubtractCharCount(char c, string strNumber, int num, int[] charCounts, int[] numberCounts){
        var curCharCount = charCounts[c - 'a'];
        foreach(var n in strNumber){
            charCounts[n - 'a'] -= curCharCount;
        }
        numberCounts[num] += curCharCount;
    }
}