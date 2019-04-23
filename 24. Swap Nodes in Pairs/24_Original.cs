/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode SwapPairs(ListNode head) {
        var dummyhead = new ListNode(0);
        dummyhead.next = head;
        int i = 0;
        var cur = dummyhead;
        var nodeleft = dummyhead;
        while(cur != null){
            i++;
            cur = cur.next;
            if(i >= 2){
                if(i % 2 == 0 && cur != null){
                    nodeleft.next.next = cur.next;
                    cur.next = nodeleft.next;
                    nodeleft.next = cur;
                    cur = cur.next;
                }
                nodeleft = nodeleft.next; 
            }
        }
        return dummyhead.next;
    }
}