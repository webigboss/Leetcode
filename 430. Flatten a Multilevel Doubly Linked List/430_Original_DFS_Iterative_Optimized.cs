/*
// Definition for a Node.
public class Node {
    public int val;
    public Node prev;
    public Node next;
    public Node child;

    public Node(){}
    public Node(int _val,Node _prev,Node _next,Node _child) {
        val = _val;
        prev = _prev;
        next = _next;
        child = _child;
}
*/
public class Solution {
    public Node Flatten(Node head) {
        //DFS iterative approach otptimized: with stack only save next node from previous level;
        if(head == null) return null;
        var st = new Stack<Node>();
        var cur = head;
        
        while(true){
            if(cur.child != null){
                if(cur.next != null)
                    st.Push(cur.next);
                cur.next = cur.child;
                cur.next.prev = cur;
                cur.child = null;
                cur = cur.next;
                continue;
            }
            
            if(cur.next != null){
                cur = cur.next;
            }
            else{ // cur.next == null
                if(st.Count == 0)
                    break;
                var next = st.Pop();
                cur.next = next;
                next.prev = cur;
                cur = next;
            }
        }
        return head;
    }
}