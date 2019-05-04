/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;

    public Node(){}
    public Node(int _val,Node _next,Node _random) {
        val = _val;
        next = _next;
        random = _random;
}
*/
public class Solution {
    public Node CopyRandomList(Node head) {
        var ht = new Hashtable();
        var copyHead = new Node();
        var cur = copyHead;
        var oldcur = head;
        while(oldcur != null){
            cur.next = new Node(oldcur.val, null, null);
            cur = cur.next;
            ht.Add(oldcur, cur);
            oldcur = oldcur.next;
        }
        
        cur = copyHead.next;
        while(head != null){
            if(head.random != null)
                cur.random = (Node)ht[head.random];
            cur = cur.next;
            head = head.next;
        }
        
        return copyHead.next;
    }
}