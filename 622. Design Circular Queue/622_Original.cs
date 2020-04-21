public class MyCircularQueue {

    private int[] arr;
    private int head;
    private int tail;
    private int _k;
    private int _count;
    /** Initialize your data structure here. Set the size of the queue to be k. */
    public MyCircularQueue(int k) {
        _k = k;
        arr = new int[k];
        head = 0;
        tail = 0;
        _count = 0;
    }
    
    /** Insert an element into the circular queue. Return true if the operation is successful. */
    public bool EnQueue(int value) {
        if(_count == _k) return false;
        arr[tail] = value;
        tail = (tail + 1) % _k;
        _count++;
        return true;
    }
    
    /** Delete an element from the circular queue. Return true if the operation is successful. */
    public bool DeQueue() {
        if(_count == 0) return false;
        head = (head + 1) % _k;
        _count--;
        return true;
    }
    
    /** Get the front item from the queue. */
    public int Front() {
        if(_count == 0) return -1;
        return arr[head];
    }
    
    /** Get the last item from the queue. */
    public int Rear() {
        if(_count == 0) return -1;
        return arr[(tail - 1 + _k) % _k];
    }
    
    /** Checks whether the circular queue is empty or not. */
    public bool IsEmpty() {
        return _count == 0;
    }
    
    /** Checks whether the circular queue is full or not. */
    public bool IsFull() {
        return _count == _k;
    }
}

/**
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue obj = new MyCircularQueue(k);
 * bool param_1 = obj.EnQueue(value);
 * bool param_2 = obj.DeQueue();
 * int param_3 = obj.Front();
 * int param_4 = obj.Rear();
 * bool param_5 = obj.IsEmpty();
 * bool param_6 = obj.IsFull();
 */