/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode Partition(ListNode head, int x) {
        var dummyhead = new ListNode(0);
        var tail = new ListNode(0);
        dummyhead.next = head;
        var curhead = head;
        var curprev = dummyhead;
        var curtail = tail;
        
        while(curhead != null){
            if(curhead.val >= x){
                curprev.next = curhead.next;
                curtail.next = curhead;
                curhead = curhead.next;
                curtail = curtail.next;
                curtail.next = null;
            }
            else{
                curprev = curprev.next;
                curhead = curhead.next;
            }
            
        }
        curprev.next = tail.next;
        return dummyhead.next;
    }
}