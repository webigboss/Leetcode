/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        if(head == null)
            return null;
        var dummyHead = new ListNode(int.MaxValue);
        dummyHead.next = head;
        var left = dummyHead;
        var mid = head;
        var right = head.next;
        var duplicate = false;
        while(true){
            if(right == null){
                if(duplicate)
                    left.next = right;
                break;
            }   
            else{
                if(mid.val == right.val){
                    duplicate = true;
                    mid = mid.next;
                    right = right.next;
                }
                else{ 
                    if(duplicate){
                        left.next = right;
                        mid = mid.next;
                        right = right.next;
                        duplicate = false;
                    }
                    else{ // shift 3 pointers at 1 step to the right
                        left = left.next;
                        mid = mid.next;
                        right = right.next;
                    }  
                }
            }
        }
        return dummyHead.next;
    }
}