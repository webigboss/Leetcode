using System;
namespace AlgorithmPlayground{
     
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public class LinkedListRandomNode {

        /** @param head The linked list's head.
            Note that the head is guaranteed to be not null, so it contains at least one node. */
        private ListNode _head;
        private int _count;
        private Random _rdn;
        public LinkedListRandomNode(ListNode head) {
            _head = head;
            _rdn = new Random();
        }
        
        /** Returns a random node's value. */
        public int GetRandom() {
            var _cur = _head;
            var result = _cur.val;
            while(_cur != null){
                _count++;
                result = _rdn.Next() % _count == 0 ? _cur.val : result;
                _cur = _cur.next;
            }
            return result;
        }
    }
}