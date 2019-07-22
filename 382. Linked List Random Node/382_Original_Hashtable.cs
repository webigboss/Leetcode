/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {

    /** @param head The linked list's head.
        Note that the head is guaranteed to be not null, so it contains at least one node. */
    private Random _rdn;
    private int _length;
    private Dictionary<int, int> _dict;
    public Solution(ListNode head) {
        _rdn = new Random();
        _dict = new Dictionary<int, int>();
        while(head != null){
            _dict[_length++] = head.val;
            head = head.next;
        }
    }
    
    /** Returns a random node's value. */
    public int GetRandom() {
        var rndIndex = _rdn.Next() % _length;
        return _dict[rndIndex];
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(head);
 * int param_1 = obj.GetRandom();
 */