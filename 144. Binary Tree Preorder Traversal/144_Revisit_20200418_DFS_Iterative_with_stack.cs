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
        //DFS interative with a stack
        //note to make sure left node got pop out first, we need to add right node first then left node
        if(root == null) return new List<int>();
        var st = new Stack<TreeNode>();
        var result = new List<int>();
        st.Push(root);
        while(st.Count > 0){
            var node = st.Pop();
            result.Add(node.val);
            if(node.right != null)
                st.Push(node.right);
            if(node.left != null)
                st.Push(node.left);
        }
        return result;
    }
}