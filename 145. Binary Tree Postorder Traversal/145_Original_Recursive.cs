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
        //recursive solution
        var list = new List<int>();
        PostorderTraversalRecursively(root, list);
        
        return list;
    }
    
    private void PostorderTraversalRecursively(TreeNode n, List<int> list){
        if(n == null)
            return;
        
        PostorderTraversalRecursively(n.left, list);
        PostorderTraversalRecursively(n.right, list);
        list.Add(n.val);
    }
}