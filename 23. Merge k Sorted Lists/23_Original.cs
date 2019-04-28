/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        var mergedList = new ListNode(0);
        var cur = mergedList;
        var minIndex = new List<int>();
        var min = int.MaxValue;
        ListNode tempNode = null;
        while(true){
            for(var i = 0; i < lists.Length; i++){
                if(lists[i] == null)
                    continue;
                if(lists[i].val == min){
                    minIndex.Add(i);
                }
                else if(lists[i].val < min){
                    minIndex.Clear();
                    minIndex.Add(i);
                    min = lists[i].val;
                }
            }
            if(minIndex.Count == 0)
                break;
            foreach(var i in minIndex){
                tempNode = lists[i];
                lists[i] = lists[i].next;
                tempNode.next = null;
                cur.next = tempNode;
                cur = cur.next;
            }
            minIndex.Clear();
            min = int.MaxValue;
        }
        return mergedList.next;
    }
}