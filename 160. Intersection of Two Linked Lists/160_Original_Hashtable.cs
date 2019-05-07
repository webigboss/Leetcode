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
        //hashtable solution
        var ht = new Hashtable();
        while(headA != null){
            ht.Add(headA, null);
            headA = headA.next;
        }
        
        while(headB != null){
            if(ht.ContainsKey(headB))
                return headB;
            headB = headB.next;
        }
        return null;
    }
}