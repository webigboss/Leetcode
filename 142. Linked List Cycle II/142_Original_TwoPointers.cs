/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        if(head == null || head.next == null)
            return null;
        var one = head;
        var two = head;
        
        while(true){
            if(one.next == null)
                return null;
            else
                one = one.next;
            
            if(two.next == null || two.next.next == null)
                return null;
            else
                two = two.next.next;
            
            if(one == two)
                break;
        }
        one = head;
        while(true){
            if(one == two)
                break;
            one = one.next;
            two = two.next;
        }
        return two;
    }
}