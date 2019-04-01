//Recursion solution
//definition for a binary tree node.
  public class treenode {
      public int val;
      public treenode left;
      public treenode right;
      public treenode(int x) { val = x; }
    }
public class Solution {
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        return BuildTreeRecursively(preorder, inorder);
    }
    
    private TreeNode BuildTreeRecursively(int[] preorder, int[] inorder){
        if(preorder.Length == 0 || inorder.Length == 0)
            return null;
        var root = preorder[0];
        var n = new TreeNode(root);
        var iroot = Array.IndexOf(inorder, root);
        
        var preleft = new int[iroot];
        var preright = new int[preorder.Length - 1 - iroot];
        Array.Copy(preorder, 1, preleft, 0, iroot);
        Array.Copy(preorder, 1 + iroot, preright, 0, preorder.Length - 1 - iroot);
        
        var inleft = new int[iroot];
        var inright = new int[preorder.Length - 1 - iroot];
        Array.Copy(inorder, 0, inleft, 0, iroot);
        Array.Copy(inorder, iroot + 1, inright, 0, preorder.Length - 1 - iroot);
        
        n.left = BuildTreeRecursively(preleft, inleft);
        n.right = BuildTreeRecursively(preright, inright);
        return n;
    }
}