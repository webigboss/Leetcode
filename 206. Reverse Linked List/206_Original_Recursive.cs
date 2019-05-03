/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        //recursive solution
        if(head == null)
            return null;
        var dummyHead = new ListNode(0);
        dummyHead.next = head;
        var cur = dummyHead;
        ReverseListRecursive(ref head, cur, dummyHead);
        return head;
    }
    
    private ListNode ReverseListRecursive(ref ListNode head, ListNode cur, ListNode dummyHead){
        if(cur.next == null){
            head = cur;
            return cur;
        }
        else{
            var node = ReverseListRecursive(ref head, cur.next, dummyHead);
            if(cur == dummyHead)
                node.next = null;
            else
                node.next = cur;
            return cur;
        }
    }
}