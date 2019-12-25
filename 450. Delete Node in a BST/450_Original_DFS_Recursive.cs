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
    public TreeNode DeleteNode(TreeNode root, int key) {
        //recursively check current node and it's child
        //of root.val != key, recursively pass root's left and right child to the same method and assign the returned node to left and right child
        
        if(root == null) return null;
        if(root.val == key) {
            //case 1: both left and right nodes are null;
            if(root.left == null && root.right == null) return null;
            
            //case 2: left node is not null, right is null;
            if(root.left != null && root.right == null) return root.left;
            
            //case 3: right node is not null, left is null;
            if(root.left == null && root.right != null) return root.right;
            
            //case 4: both left and right nodes are not null, find the minimum value in the right tree and change the value of root to it,
            var min = FindMin(root.right);
            root.val = min;
            //delete the min node from the right sub-tree !!!!!! the most brilliant thought in this solution
            root.right = DeleteNode(root.right, min);
            return root;            
        }
        else if(root.val > key){
            root.left = DeleteNode(root.left, key);
        }
        else{ //root.val < key
            root.right = DeleteNode(root.right, key);
        }
        return root;
    }
    
    private int FindMin(TreeNode node) {
        while(node.left != null) {
            node = node.left;
        }
        return node.val;
    }
}