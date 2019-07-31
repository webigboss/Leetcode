public class Solution {
    public IList<string> ReadBinaryWatch(int num) {
        var result = new List<string>();
        for (var h = 0; h < 12; h++){
            for(var m = 0; m < 60; m++){
                if(bitCount(h << 6 | m) == num)
                    result.Add(string.Format("{0}:{1:D2}", h, m));
            }
        }
        return result;
    }
    
    
    private int bitCount(int n){
        var count = 0;
        
        while(n != 0){
            if(n % 2 == 1) count++;
            n /= 2;
        }
        return count;
    }
}