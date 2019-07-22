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
    private ListNode _head;
    private int _count;
    private Random _rdn;
    public Solution(ListNode head) {
        _head = head;
        _rdn = new Random();
    }
    
    /** Returns a random node's value. */
    public int GetRandom() {
        var _cur = _head.next;
        var result = _head.val;  
        for(int i = 1; _cur.next != null; i++){
            _cur = _cur.next;
            if(_rdn.Next(i + 1) == i) result = _cur.val;                        
        }
        return result;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(head);
 * int param_1 = obj.GetRandom();
 */