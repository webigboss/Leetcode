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
    public IList<string> BinaryTreePaths(TreeNode root) {     
        var result = new List<string>();
        if(root == null)
            return result;
        DfsHelper(root, root.val.ToString(), result);
        return result;
    }
    
    private void DfsHelper(TreeNode node, string path, IList<string> result){
        if(node.left != null)
            DfsHelper(node.left, path + "->" + node.left.val, result);
        
        if(node.right != null)
            DfsHelper(node.right, path + "->" + node.right.val, result);
        
        if(node.left == null && node.right == null)
            result.Add(path);
    }
}