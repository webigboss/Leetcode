/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseKGroup(ListNode head, int k) {
        var dummyHead = new ListNode(0);
        dummyHead.next = head;
        var pointer1 = dummyHead;
        var pointer2 = dummyHead;
        ListNode curFirst = null;
        ListNode curLast = null;
        ListNode nextFirst = null;
        ListNode prevLast = dummyHead;
        ListNode prevTemp = null;
        ListNode temp = null;
        int step;
        while(true){
            //pointer1 move k steps, 
            step = 0;
            while(pointer1 != null && step < k){
                pointer1 = pointer1.next;
                if(pointer1 != null) step++;
                if(step == 1)
                    curFirst = pointer1;
            }
            //if reaches the end before move k steps then break
            if(step < k) break; 
            curLast = pointer1;
            nextFirst = pointer1.next;
            
            //pointer2 move k steps and then reverse the k nodes
            prevTemp = null;
            while(true){
                //last element met which is pointer1, then just point it to its previous without doing other things, and break the loop
                if(pointer2 == pointer1){
                    pointer2.next = prevTemp;
                    break;
                }
                temp = pointer2.next;
                pointer2.next = prevTemp;
                prevTemp = pointer2;
                pointer2 = temp;
            }
            curFirst.next = nextFirst;
            prevLast.next = curLast;
            prevLast = curFirst;
            pointer1 = curFirst;
            pointer2 = curFirst;
        }
       
        return dummyHead.next;
    }
}