public class Solution {

    private int[] _array;
    private int _last;
    private Random _rdm;
    private int _cols;
    public Solution(int n_rows, int n_cols) {
        _rdm = new Random();
        _last = n_rows * n_cols - 1;
        _array = new int[n_rows * n_cols];
        _cols = n_cols;
        for(var i = 0; i < _array.Length; i++){
            _array[i] = i;
        }
    }
    
    public int[] Flip() {
        var i = _rdm.Next(_last + 1);
        var temp = _array[i];
        _array[i] = _array[_last];
        _array[_last] = temp;
        _last--;
        return new []{temp / _cols, temp % _cols };
    }
    
    public void Reset() {
        _last = _array.Length - 1;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(n_rows, n_cols);
 * int[] param_1 = obj.Flip();
 * obj.Reset();
 */