public class MinStack {
    // One Stack Solution, record 2nd minimum value
    
    private Stack _st;
    private int _min;
    
    public MinStack() {
        _st = new Stack();
        _min = int.MaxValue;
    }
    
    public void Push(int x) {
        if(x <= _min){
            _st.Push(_min);
            _min = x;
        }
        _st.Push(x);
    }
    
    public void Pop() {
        if((int)_st.Pop() == _min){
            _min = (int)_st.Pop();
        }        
    }
    
    public int Top() {
        return (int)_st.Peek();
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