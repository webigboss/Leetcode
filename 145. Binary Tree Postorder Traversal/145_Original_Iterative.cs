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
    public IList<int> PostorderTraversal(TreeNode root) {
        //iterative solution, post order traversal result 
        //equal to the reverse of the reversed preorder traversal
        var list = new List<int>();
        var st = new Stack();
        while(st.Count != 0 || root != null){
            while(root != null){
                st.Push(root);
                list.Add(root.val);
                root = root.right;
            }
            root = ((TreeNode)st.Pop()).left; 
        }
        list.Reverse();
        return list;
    }
}