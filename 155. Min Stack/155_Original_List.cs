public class MinStack {

    /** initialize your data structure here. */
    private int _min;
    private List<int> _stackList;
    public MinStack() {
        _min = int.MaxValue;
        _stackList = new List<int>();
    }
    
    public void Push(int x) {
        _stackList.Add(x);
        _min = Math.Min(x, _min);
    }
    
    public void Pop() {
        if(_stackList[_stackList.Count - 1] == _min){
            _min = int.MaxValue;
            for(var i = 0; i < _stackList.Count - 1; i++)
                _min = Math.Min(_min, _stackList[i]);
        }
        _stackList.RemoveAt(_stackList.Count - 1);
    }
    
    public int Top() {
        return _stackList[_stackList.Count - 1];
    }
    
    public int GetMin() {
        return _min;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */