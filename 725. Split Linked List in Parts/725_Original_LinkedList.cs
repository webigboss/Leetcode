/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode[] SplitListToParts(ListNode root, int k) {
        var len = GetListLength(root);
        int div = len/k, mod = len%k;
        Console.WriteLine($"Length:{len}, div:{div}, mod:{mod}");
        var ans = new List<ListNode>();
        var dummyHead = new ListNode(0);
        dummyHead.next = root;
        var cur = dummyHead;
        if(root != null)
            ans.Add(dummyHead.next);
        ListNode temp = null;
        while(k > 0){
            var advanced = false;
            for(var i = 0; i < div; ++i){
                cur = cur.next;
                advanced = true;
            }
            if(mod > 0){
                cur = cur.next;
                advanced = true;
                mod--;
            }
            if(temp!= null)
                temp.next = null;
            if(advanced){                
                Console.WriteLine($"ans.Add() cur.val:{cur.val}");
                if(cur.next != null) ans.Add(cur.next);
                temp = cur;
            }
            else{
                Console.WriteLine("ans.Add(null)");
                ans.Add(null);
            }
            k--;
        }
        
        return ans.ToArray();
    }
    
    private int GetListLength(ListNode node) {
        if(node == null) return 0;
        return GetListLength(node.next) + 1;
    }
}