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
        var ht = new Hashtable();
        var cur = head;
        ListNode result = null;
        while(cur != null){
            if(ht.ContainsKey(cur)){
                result = cur;
                break;
            }
            else{
                ht.Add(cur, null);
            }
            cur = cur.next;
        }
        return result;
    }
}