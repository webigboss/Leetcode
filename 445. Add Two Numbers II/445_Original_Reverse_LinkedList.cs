/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        if(l1 == null)
            return l2;
        if(l2 == null)
            return l1;
        //reverse 2 linked list 
        var r1 = Reverse(l1);
        var r2 = Reverse(l2);
        var advance = 0;
        
        var cur1 = r1;
        var cur2 = r2;
        while(true){
            if(cur1.val + cur2.val + advance >= 10){
                cur1.val = (cur1.val + cur2.val + advance) % 10;
                advance = 1;
            }
            else{
                cur1.val = cur1.val + cur2.val + advance;
                advance = 0;
            }
            
            if(cur1.next == null && cur2.next == null && advance == 0) break;
            
            if(cur1.next == null)
                cur1.next = new ListNode(0);
            cur1 = cur1.next;
            if(cur2.next == null)
                cur2.next = new ListNode(0);
            cur2 = cur2.next;
        }
        l1 = Reverse(r1);
        return l1;
    }
    
    private ListNode Reverse(ListNode node){
        ListNode temp = null;
        ListNode prev = null;
        while(node != null){
            temp = node.next;
            node.next = prev;
            prev = node;
            node = temp;
        }
        return prev;
    }
}