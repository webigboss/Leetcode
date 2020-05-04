public class MyLinkedList {
    
    public class Node{
        public int val {get;set;}
        public Node next {get;set;}
        public Node(int value){
            val = value;
        }
    }
    
    private Node dummyHead;
    private Node cur;
    private int cnt;
    /** Initialize your data structure here. */
    public MyLinkedList() {
        dummyHead = new Node(0);
        cur = dummyHead;
        cnt = 0;
    }
    
    /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
    public int Get(int index) {
        if(index >= cnt) return -1;
        var i = -1;
        var node = dummyHead;
        while(i < index){
            node = node.next;
            i++;
        }
        return node.val;
    }
    
    /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
    public void AddAtHead(int val) {
        var node = new Node(val);
        if(dummyHead.next == null){
            dummyHead.next = node;
            cur = node;
        }
        else{
            node.next = dummyHead.next;
            dummyHead.next = node;
        }
        cnt++;
    }
    
    /** Append a node of value val to the last element of the linked list. */
    public void AddAtTail(int val) {
        var node = new Node(val);
        cur.next = node;
        cur = node;
        cnt++;
    }
    
    /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
    public void AddAtIndex(int index, int val) {
        if(index > cnt) 
            return;
        if(index == cnt){
            AddAtTail(val);
            return;
        }
        var i = 0;
        var node = dummyHead;
        while(i < index){
            node = node.next;
            i++;
        }
        var newnode = new Node(val);
        newnode.next = node.next;
        node.next = newnode;
        cnt++;
    }
    
    /** Delete the index-th node in the linked list, if the index is valid. */
    public void DeleteAtIndex(int index) {
        if(index >= cnt) 
            return;
        
        var i = 0;
        var node = dummyHead;
        while(i < index){
            node = node.next;
            i++;
        }
        node.next = node.next.next;
        if(index == cnt - 1)
            cur = node;
        cnt--;
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */