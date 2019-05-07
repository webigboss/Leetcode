/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        if(headA == null || headB == null)
            return null;
        var curA = headA;
        var curB = headB;
        var changedA = false;
        while(curA != curB){
            if(curA.next == null){
                if(!changedA){
                    curA = headB;
                    changedA = true;
                }
                else
                    return null;
            }
            else
                curA = curA.next;
            if(curB.next == null){
                curB = headA;
            }
            else
                curB = curB.next;
        }
        return curA;
    }
}