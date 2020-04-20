using System.Text.RegularExpressions;
public class Solution {
    public string FractionAddition(string expression) {
        var exps = Regex.Split(expression, @"(?=[+-])");
        
        var num = "0/1";
        foreach(var exp in exps){
            if(string.IsNullOrEmpty(exp)) continue;
            num = Add(num, exp);
        }
        return num;
    }
    
    private string Add(string a, string b){
        var arra = a.Split('/');
        int a1 = int.Parse(arra[0]);
        int a2 = int.Parse(arra[1]);
        var arrb = b.Split('/');
        int b1 = int.Parse(arrb[0]);
        int b2 = int.Parse(arrb[1]);
        
        var c1 = a1 * b2 + b1 * a2;
        var c2 = a2 * b2;
        var gcd = GetGCD(c1, c2);
        return (c1/gcd).ToString() + '/' + (c2/gcd).ToString();
    }
    
    private int GetGCD(int a, int b){
        if(a == 0 || b == 0) return Math.Abs(a + b);
        return GetGCD(b, a % b);
    }
}

