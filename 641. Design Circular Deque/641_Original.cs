public class MyCircularDeque {

    private int _l;
    private int _c;
    private int[] _arr;
    private int head;
    private int tail;
    /** Initialize your data structure here. Set the size of the deque to be k. */
    public MyCircularDeque(int k) {
        _arr = new int[k];
        _l = k;
        _c = 0;
        head = 0;
        tail = 0;
    }
    
    /** Adds an item at the front of Deque. Return true if the operation is successful. */
    public bool InsertFront(int value) {
        if(_c == _l) return false;
        head = (head - 1 + _l) % _l;
        _arr[head] = value;
        _c++;
        return true;
    }
    
    /** Adds an item at the rear of Deque. Return true if the operation is successful. */
    public bool InsertLast(int value) {
        if(_c == _l) return false;
        _arr[tail] = value;
        tail = (tail + 1) % _l;
        _c++;
        return true;
    }
    
    /** Deletes an item from the front of Deque. Return true if the operation is successful. */
    public bool DeleteFront() {
        if(_c == 0) return false;
        head = (head + 1) % _l;
        _c--;
        return true;
    }
    
    /** Deletes an item from the rear of Deque. Return true if the operation is successful. */
    public bool DeleteLast() {
        if(_c == 0) return false;
        tail = (tail - 1 + _l) % _l;
        _c--;
        return true;
    }
    
    /** Get the front item from the deque. */
    public int GetFront() {
        if(_c == 0) return -1;
        return _arr[head];
    }
    
    /** Get the last item from the deque. */
    public int GetRear() {
        if(_c == 0) return -1;
        return _arr[(tail - 1 + _l) % _l];
    }
    
    /** Checks whether the circular deque is empty or not. */
    public bool IsEmpty() {
        return _c == 0;
    }
    
    /** Checks whether the circular deque is full or not. */
    public bool IsFull() {
        return _c == _l;
    }
}

/**
 * Your MyCircularDeque object will be instantiated and called as such:
 * MyCircularDeque obj = new MyCircularDeque(k);
 * bool param_1 = obj.InsertFront(value);
 * bool param_2 = obj.InsertLast(value);
 * bool param_3 = obj.DeleteFront();
 * bool param_4 = obj.DeleteLast();
 * int param_5 = obj.GetFront();
 * int param_6 = obj.GetRear();
 * bool param_7 = obj.IsEmpty();
 * bool param_8 = obj.IsFull();
 */