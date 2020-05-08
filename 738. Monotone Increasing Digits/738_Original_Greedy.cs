public class Solution {
    public int MonotoneIncreasingDigits(int N) {
        var arr = N.ToString().ToCharArray();
        var index = arr.Length;
        for(var i = arr.Length-1; i >= 0; --i){
            if(i > 0 && arr[i] < arr[i-1]){
                index = i;
                arr[i-1]--;
            }
        }
        
        for(var i = index; i < arr.Length; ++i)
            arr[i] = '9';
        
        return int.Parse(new string(arr));
    }
}