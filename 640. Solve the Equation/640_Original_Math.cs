public class Solution {
    public string SolveEquation(string equation) {
        var eqs = equation.Split('=');
        var l = Parse(eqs[0]);
        var r = Parse(eqs[1]);
        //return $"l[0]:{l[0]}, l[1]:{l[1]}, r[0]:{r[0]}, r[1]:{r[1]}";
        if(l[1] == r[1]){
            if(l[0] != r[0])
                return "x=0";
            else
                return "Infinite solutions";
        }
        if(l[0] == r[0])
            return "No solution";
        
        var num = (int)((r[1] - l[1]) / (l[0] - r[0]));
        return "x="+num;
    }
    
    private int[] Parse(string str) { 
        var sb = new StringBuilder();
        var num = 0;
        var xco = 0;
        bool isX = false;
        foreach(var c in str){
            if(c == '+' || c== '-'){
                var s = sb.ToString();
                if(isX){
                    if(s == "+" || string.IsNullOrEmpty(s))
                        xco++;
                    else if(s == "-")
                        xco--;
                    else 
                        xco += int.Parse(s);
                }
                else{
                    if(!string.IsNullOrEmpty(s))
                        num += int.Parse(s);
                }
                isX = false;
                sb.Clear();
                sb.Append(c);
            }
            if(Char.IsDigit(c))
                sb.Append(c);
            if(c == 'x')
                isX = true;
        }
        
        var s1 = sb.ToString();
        if(isX){
            if(s1 == "+" || string.IsNullOrEmpty(s1))
                xco++;
            else if(s1 == "-")
                xco--;
            else 
                xco += int.Parse(s1);
        }
        else{
            if(!string.IsNullOrEmpty(s1))
                num += int.Parse(s1);
        }
        
        return new []{xco, num};
    }
}
