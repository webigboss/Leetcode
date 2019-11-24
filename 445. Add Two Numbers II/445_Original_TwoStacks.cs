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
        //approach with 2 stacks
        var st1 = new Stack<int>();
        var st2 = new Stack<int>();
        
        while(l1 != null){
            st1.Push(l1.val);
            l1 = l1.next;
        }
        while(l2 != null){
            st2.Push(l2.val);
            l2 = l2.next;
        }
        ListNode result = new ListNode(0);
        int sum = 0;
        while(st1.Count > 0 || st2.Count > 0){
            sum = result.val;
            if(st1.Count > 0) sum += st1.Pop();
            if(st2.Count > 0) sum += st2.Pop();
            result.val = sum % 10;
            var prev = new ListNode(sum / 10);
            prev.next = result;
            result = prev; 
        }
        return result.val == 0 ? result.next : result;
    }
}