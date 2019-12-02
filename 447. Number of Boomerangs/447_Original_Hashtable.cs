public class Solution {
    public int NumberOfBoomerangs(int[][] points) {
        //hashtable approach
        int result = 0;
        var dict = new Dictionary<double, int>();
        for(var i = 0; i < points.Length; i++){
            dict.Clear();
            for(var j = 0; j < points.Length; j++){
                if(j == i) continue;
                var distance = GetDistance(points[i], points[j]);
                if(dict.ContainsKey(distance))
                    dict[distance]++;
                else
                    dict[distance] = 1;
            }
            
            foreach(var kvp in dict){
                if(kvp.Value > 1)
                    result += nPr(kvp.Value, 2);
            }
        }
        return result;
    }
    
    private double GetDistance(int[] a, int[] b){
        return Math.Sqrt(Math.Pow(Math.Abs(a[0] - b[0]), 2) + Math.Pow(Math.Abs(a[1] - b[1]), 2));
    }
    
    private double Factorial(int n){
        if(n <= 1) return 1;
        return n * Factorial(n - 1);
    }
    
    //combination r out of n
    private int nCr(int n, int r){
        if(n == r) return 1;
        return (int)(Factorial(n) / (Factorial(r) * Factorial(n - r)));
    }
        
    //permutation r out of n
    private int nPr(int n, int r){
        return (int)(Factorial(n) / Factorial(n - r));
    }
}