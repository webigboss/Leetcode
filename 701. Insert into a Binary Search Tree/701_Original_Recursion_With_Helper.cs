public class Solution {
    public TreeNode InsertIntoBST(TreeNode root, int val) {
        Helper(root, val);
        return root;
    }
    
    public void Helper(TreeNode node, int val){
        if(node == null) return;
        if(node.val > val){
            if(node.left == null)
                node.left = new TreeNode(val);
            else
                Helper(node.left, val);
        }
        else{
            if(node.right == null)
                node.right = new TreeNode(val);
            else
                Helper(node.right, val);
        }
    }
}