/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
        if(head == null || head.next == null)
            return true;
        if(head.next.next == null){
            if(head.val == head.next.val)
                return true;
            else
                return false;
        }
        // find mid
        var p1 = head;
        var p2 = head;
        ListNode preP1 = null;
        while(true){
            if(p2.next == null){
                //odd case, when p1 at 4, p2 at 1 of 1-2-3-4-3-2-1
                // advance p1 one more step to right so we get the head of the second half, no need to advance prev
                p1 = p1.next;
                break;
            }
            if(p2.next.next == null){
                //even case, when p1 at the 2nd 4, p2 at 1 of 1-2-3-4-4-3-2-1
                // advance p1 and prevP1 one more step to right so we get the head of the second half
                preP1 = p1;
                p1 = p1.next;
                break;
            }
            preP1 = p1;
            p1 = p1.next;
            p2 = p2.next.next;
        }
        //get the last node of first half to null, cut the list
        preP1.next = null;
        var revP1 = Reverse(p1);
        while(revP1 != null && head != null){
            if(revP1.val != head.val)
                return false;
            else{
                revP1 = revP1.next;
                head = head.next;
            }
        }
        if(revP1 == null && head == null)
            return true;
        else 
            return false;
    }
    
    private ListNode Reverse(ListNode head){
        var cur = head;
        ListNode prev = null;
        ListNode temp = null;
        
        while(cur != null){
            temp = cur.next;
            cur.next = prev;
            prev = cur;
            cur = temp;
        }
        return prev;
    }
}