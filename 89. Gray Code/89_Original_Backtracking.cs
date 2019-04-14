public class Solution {
    public IList<int> GrayCode(int n) {
        //backtracking solution
        var result = new List<int>();
        //initialize a [0] array even if n == 0 for spacial case
        var arrayBinary = new int[n == 0 ? 1 : n];
        var count = (int)Math.Pow(2, n);
        
        GrayCodeBacktracking(count, n, arrayBinary, result);
        return result;
    }
    
    
    private void GrayCodeBacktracking(int count, int n, int[] arrayBinary, IList<int> result){
        if(result.Count == count)
            return;
        var number = Convert.ToInt32(ConvertFromIntArray(arrayBinary), 2);
        if(!result.Contains(number)){
            result.Add(number);    
        }
        else
            return;
        
        for(var i = n - 1; i >= 0; i--){
            arrayBinary[i] = arrayBinary[i] == 0 ? 1 : 0;
            GrayCodeBacktracking(count, n, arrayBinary, result);
            arrayBinary[i] = arrayBinary[i] == 0 ? 1 : 0;
        }
        
    }
    
    private string ConvertFromIntArray(int[] a){
        var sb = new StringBuilder();
        foreach(var i in a){
            sb.Append(i);
        }
        return sb.ToString();
    }
    
}