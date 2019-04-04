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
    public IList<int> PreorderTraversal(TreeNode root) {
        //iterative solution
        var list = new List<int>();
        var st = new Stack();
        
        while(st.Count != 0 || root != null){
            while(root != null){
                list.Add(root.val);
                st.Push(root);
                root = root.left;
            }
            root = ((TreeNode)st.Pop()).right;
        }
        return list;
    }
}