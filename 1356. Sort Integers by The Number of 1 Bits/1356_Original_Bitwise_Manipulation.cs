public class Solution {
    public int[] SortByBits(int[] arr) {
        Array.Sort(arr, (a, b) =>{
            var ca = BitCount(a);
            var cb = BitCount(b);
            if(ca != cb) return ca - cb;
            else return a - b;
        });
        return arr;
    }
    
    private int BitCount(int n){
        var count = 0;
        while(n != 0){
            n &= n - 1;
            count++;
        }
        return count;
    }
}