/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void ReorderList(ListNode head) {
        var nodeList = new List<ListNode>();
        var cur = head;
        while(cur != null){
            nodeList.Add(cur);
            cur = cur.next;
        }
        var left = 0;
        var right = nodeList.Count - 1;
        ListNode temp;
        while(left <= right){
            if(left == right) {// end scenario for odd number of nodes, remove cycle in linklist
                nodeList[left].next = null;
                break;
            }
            temp = nodeList[left].next;
            nodeList[left].next = nodeList[right];
            nodeList[right].next = temp;    
            if(temp.next == nodeList[right]) // end scenario for even number of nodes, remove cycle in linklist
                temp.next = null;
            left++;
            right--;
        }
    }
}