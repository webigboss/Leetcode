/**
	one pass algorithm, 
    Time complexity O(n), 
    space complexity O(n), 
    need to familiarize and finish the solution in solution section, 
    they both have contant O(1) space complexity.
    Especially the one pass solution is brilliant.
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        var cur = head;
        var index = 0;
        var nodeList = new List<ListNode>();
        while(cur != null){
            nodeList.Add(cur);
            cur = cur.next;
        }
        if(nodeList.Count == 1)
            return null;
        if(nodeList.Count == n)
            return head.next;
        nodeList[nodeList.Count - n - 1].next = n > 1 ? nodeList[nodeList.Count - n + 1] : null;
        
        return head;
    }
}