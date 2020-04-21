public class Solution {
    public TreeNode AddOneRow(TreeNode root, int v, int d) {
        return Helper(root, v, d, 1, true);
    }
    
    private TreeNode Helper(TreeNode node, int v, int d, int c, bool isleft){
        if(node == null && d != c) return null; //d!= c to make sure still creating a node value = v when d==c even if it's null
        
        if(d == c){
            var newNode = new TreeNode(v);
            if(isleft)
                newNode.left = node;
            else
                newNode.right = node;
            return newNode;
        }
        else{
            node.left = Helper(node.left, v, d, c + 1, true);
            node.right = Helper(node.right, v, d, c + 1, false);
            return node;
        }
    }
}