public class MyStack {
    // one queue solution
    
    private Queue<int> _q;
    /** Initialize your data structure here. */
    public MyStack() {
        _q = new Queue<int>();
    }
    
    /** Push element x onto stack. */
    public void Push(int x) {
        var counter = _q.Count;
        _q.Enqueue(x);
        while(counter > 0){
            _q.Enqueue(_q.Dequeue());
            counter--;
        }
    }
    
    /** Removes the element on top of the stack and returns that element. */
    public int Pop() {
        return _q.Dequeue();
    }
    
    /** Get the top element. */
    public int Top() {
        return _q.Peek();
    }
    
    /** Returns whether the stack is empty. */
    public bool Empty() {
        return _q.Count == 0;
        
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */