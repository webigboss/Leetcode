/**
two pass algorithm, 
time complexity O(n), 
space complexity is constant O(1). 
Is there a one pass algorithm?
 */
public class Solution {
    public ListNode RotateRight(ListNode head, int k) {
        if(head == null)
            return null;
        if(k == 0)
            return head;
        var dummyhead = new ListNode(0);
        dummyhead.next = head;

        var cur = dummyhead;
        var count = -1;
        var nodeleft = dummyhead;
        while(cur != null){
            count++;
            cur = cur.next;
        }
        if(k % count == 0)
            return dummyhead.next;
        k = k % count;
        
        cur = dummyhead;
        count = -1;
        while(true){
            count++;
            if(count > k)
                nodeleft = nodeleft.next;
            if(cur.next == null)
                break;
            cur = cur.next;
        }
        dummyhead.next = nodeleft.next;
        nodeleft.next = null;
        cur.next = head;
        
        return dummyhead.next;
    }
}