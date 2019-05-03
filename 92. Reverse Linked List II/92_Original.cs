/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseBetween(ListNode head, int m, int n) {
        if(m == n)
            return head;
        var dummyHead = new ListNode(0);
        dummyHead.next = head;
        var cur = head;
        var prev = dummyHead;
        var mPointer = dummyHead;
        var bmPointer = dummyHead;
        var temp = dummyHead;
        var count = 1;
        
        while(true){
            if(count == m - 1)
                bmPointer = cur;
            if(count == m)
                mPointer = cur;
            if(count == n + 1)
            {
                bmPointer.next = prev;
                mPointer.next = cur;
                break;
            }
            if(count > m && count <= n){
                temp = cur.next;
                cur.next = prev;
                prev = cur;
                cur = temp;
            }
            else{
                cur = cur.next;
                prev = prev.next;
            }
            count++;
        }
        return dummyHead.next;
    }
}