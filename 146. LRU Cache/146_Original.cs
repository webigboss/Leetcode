public class LRUCache {

    private int _capacity; 
    private Dictionary<int, int[]> _dict;
    private int _curAge;
    public LRUCache(int capacity) {
        _capacity = capacity;
        _dict = new Dictionary<int, int[]>();
        _curAge = 0;
    }
    
    public int Get(int key) {
        if(_dict.ContainsKey(key)){
            _dict[key][1] = ++_curAge; 
            return _dict[key][0];
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        if(_dict.Count < _capacity || _dict.ContainsKey(key)){
            _dict[key] = new int[] { value, ++_curAge };
        }
        else{
            int minKey = 0;
            int minAge = int.MaxValue;
            foreach(var k in _dict.Keys){
                if(_dict[k][1] < minAge){
                    minAge = _dict[k][1];
                    minKey = k;
                }
            }
            _dict.Remove(minKey);
            _dict[key] = new int[] { value, ++_curAge };
        }
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */