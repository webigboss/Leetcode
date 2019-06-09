public class MyQueue {

    private Stack<int> _st;
    private Stack<int> _sttemp;
    /** Initialize your data structure here. */
    public MyQueue() {
        _st = new Stack<int>();
        _sttemp = new Stack<int>();
    }
    
    /** Push element x to the back of queue. */
    public void Push(int x) {
        while(_st.Count > 0){
            _sttemp.Push(_st.Pop());
        }
        _st.Push(x);
        while(_sttemp.Count > 0){
            _st.Push(_sttemp.Pop());
        }
    }
    
    /** Removes the element from in front of queue and returns that element. */
    public int Pop() {
        return _st.Pop();
    }
    
    /** Get the front element. */
    public int Peek() {
        return _st.Peek();
    }
    
    /** Returns whether the queue is empty. */
    public bool Empty() {
        return _st.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */