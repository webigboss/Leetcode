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
        //DFS iterative approach 
        if(head == null)
            return null;
        var st = new Stack<Node>();
        var dummyHead = new Node();
        var cur = dummyHead;
        st.Push(head);
        
        
        while(st.Count > 0){
            var node = st.Pop();
            if(node.next != null)
                st.Push(node.next);
            if(node.child != null)
                st.Push(node.child);
            node.prev = cur;
            node.child = null;
            node.next = null;
            cur.next = node;
            cur = cur.next;
        }
        //the first element after dummy head don't need a previous element, so reset it back to null
        dummyHead.next.prev = null;
        return dummyHead.next;
    }
}