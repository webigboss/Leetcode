/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode OddEvenList(ListNode head) {
        if(head == null)
            return head;
        var evenHead = head.next;
        var oddCur = head;
        var evenCur = head.next;
        
        while(evenCur != null && evenCur.next != null){
            oddCur.next = oddCur.next.next;
            oddCur = oddCur.next;
            evenCur.next = evenCur.next.next;
            evenCur = evenCur.next;
        }
        oddCur.next = evenHead;
        
        return head;
    }
}