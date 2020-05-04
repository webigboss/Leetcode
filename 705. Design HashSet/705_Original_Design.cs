public class MyHashSet {

    private bool[] arr;
    /** Initialize your data structure here. */
    public MyHashSet() {
        arr = new bool[(int)1e6 + 1];
    }
    
    public void Add(int key) {
        arr[key] = true;
    }
    
    public void Remove(int key) {
        arr[key] = false;
    }
    
    /** Returns true if this set contains the specified element */
    public bool Contains(int key) {
        return arr[key] == true;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */