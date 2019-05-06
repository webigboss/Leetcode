/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode SortList(ListNode head) {
        //merge sort solution
        
        //base case
        if(head == null || head.next == null)
            return head;
        
        //logic to find the mid so to split the list in half
        ListNode preP1 = null;
        var p1 = head;
        var p2 = head;
        while(p2 != null){
            preP1 = p1;
            p1 = p1.next;
            if(p2.next != null)
                p2 = p2.next.next;
            else
                p2 = p2.next;
        }
        preP1.next = null;
        
        //recursive call for left and right half
        var left = SortList(head);
        var right = SortList(p1);
        //merge 2 sorted lists
        return Merge(left, right);
    }
    
    private ListNode Merge(ListNode left, ListNode right){
        var mergedHead = new ListNode(0);
        var mergedCur = mergedHead;
        while(left != null || right != null){
            if (left != null && right != null){
                if(left.val < right.val){
                    mergedCur.next = left;
                    mergedCur = mergedCur.next;
                    left = left.next;
                }
                else{
                    mergedCur.next = right;
                    mergedCur = mergedCur.next;
                    right = right.next;
                }
            }
            else if(left != null && right == null){
                mergedCur.next = left;
                mergedCur = mergedCur.next;
                left = left.next;
            }
            else{
                mergedCur.next = right;
                mergedCur = mergedCur.next;
                right = right.next;
            }
        }
        return mergedHead.next;  
    }
}