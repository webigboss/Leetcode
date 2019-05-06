/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode InsertionSortList(ListNode head) {
        var dummyHead = new ListNode(int.MinValue);
        dummyHead.next = head;
        
        var sortPointer = head;
        var prevSortPointer = dummyHead;
        var cur = head;
        var prev = dummyHead;
        while(true){
            if(sortPointer == null)
                    break;
            if(cur == sortPointer){
                //don't find place to insert sortPointer before cur reaching sortPointer, meaning the value of sortPointer is greater than any values                 
                //in the sorted list, move shift both sortPointer and prevSortPointer left by 1 step.
                sortPointer = sortPointer.next;
                prevSortPointer = prevSortPointer.next;
                prev = dummyHead;
                cur = dummyHead.next;
                continue;
            }
            
            if(sortPointer.val <= cur.val && sortPointer.val >= prev.val){
                //found place to insert before reaching sortPointer, prevSortPointer stay still, sortPointer point to prevSortPointer.next
                prev.next = sortPointer;
                prevSortPointer.next = sortPointer.next;
                sortPointer.next = cur;
                sortPointer = prevSortPointer.next;
                //reset cur and prev
                prev = dummyHead;
                cur = dummyHead.next;
                continue;
            }
            
            cur = cur.next;
            prev = prev.next;
        }
        
        return dummyHead.next;
    }
}