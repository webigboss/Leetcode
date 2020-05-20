public class Solution {
    public TreeNode PruneTree(TreeNode root) {
        if(Helper(root))
            return null;
        else
            return root;
    }
    
    public bool Helper(TreeNode node){
        if(node == null)
            return true;
        
        var left = Helper(node.left);
        if(left) node.left = null;
        var right = Helper(node.right);
        if(right) node.right = null;
        
        return node.val==0 && left && right;
    }
}