public class Solution {
    public string ComplexNumberMultiply(string a, string b) {
        var aParts = GetParts(a);
        var bParts = GetParts(b);
        var realPart = aParts[0] * bParts[0] - aParts[1] * bParts[1];
        var imaginaryPart = aParts[0] * bParts[1] + aParts[1] * bParts[0];
        return realPart.ToString() + '+' + imaginaryPart.ToString() + 'i';
    }
    
    private int[] GetParts(string a){
        var result = new int[2];
        var iPlus = a.IndexOf('+');
        var realPart = a.Substring(0, iPlus);
        var imaginaryPart = a.Substring(iPlus + 1, a.Length - iPlus - 2);
        return new []{int.Parse(realPart), int.Parse(imaginaryPart)};
    }
    
}