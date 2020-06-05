public class Solution {
    public ListNode MiddleNode(ListNode head) {
        int len = 0, target = 0;
        var cur = head;
        while(cur.next != null){
            len++;
            cur = cur.next;
        }
        Console.WriteLine(len);
        target = (len+1)/2;
        Console.WriteLine(target);
        len = 0;
        var ans = head;
        while(len < target){
            ans = ans.next;
            len++;
        }
        return ans;
    }
}