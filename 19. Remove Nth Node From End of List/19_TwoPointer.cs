/**
the dummy head solution is brilliant to solve corner cases like 
[1,2]
2
and 
[1,2]
1

 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        var iright = -1;
        var dummyhead = new ListNode(0);
        dummyhead.next = head;
        var nodeleft = dummyhead;
        var cur = dummyhead;
        while(cur != null){
            iright++;
            if(iright >= n + 1)
                nodeleft = nodeleft.next;
            cur = cur.next;
        }
        nodeleft.next = nodeleft.next.next;
        return dummyhead.next;
    }
}