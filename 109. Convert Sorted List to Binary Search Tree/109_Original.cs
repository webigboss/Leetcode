/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode SortedListToBST(ListNode head) {
        var list = new List<int>();
        while(head != null){
            list.Add(head.val);
            head = head.next;
        }
        var tree = SortedListToBSTRecursive( list, 0, list.Count - 1);
        return tree;
    }
    
    private TreeNode SortedListToBSTRecursive(List<int> list, int left, int right){
        if(left > right)
            return null;
        if(left == right) // only treeNode needs to be created, not sub-Tree's any more
            return new TreeNode(list[left]);
        
        int mid = (left + right) / 2;
        var node = new TreeNode(list[mid]);
        node.left = SortedListToBSTRecursive(list, left, mid - 1);
        node.right = SortedListToBSTRecursive(list, mid + 1, right);
        return node;
    }
}