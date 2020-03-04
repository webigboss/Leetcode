public class Solution {

    private int[] _w;
    private Random _rdn;
    private int _sum;
    public Solution(int[] w) {
        _w = w;
        _rdn = new Random();
        foreach(var n in _w)
            _sum += n;
    }
    
    public int PickIndex() {
        var r = _rdn.Next(_sum) + 1;
        for(var i = 0; i < _w.Length; i++){
            r -= _w[i];
            if(r < 0)
                return i;
        }
        return 0;
    }
    
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(w);
 * int param_1 = obj.PickIndex();
 */