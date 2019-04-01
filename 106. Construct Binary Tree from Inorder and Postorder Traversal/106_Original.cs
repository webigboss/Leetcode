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
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        var ht = new Hashtable();
        for(var i = 0; i < inorder.Length; i++){
            ht.Add(inorder[i], i);
        }
        return BuildTreeRecursively(inorder, 0, inorder.Length - 1, postorder, 0, postorder.Length - 1, ht);
    }
    
    private TreeNode BuildTreeRecursively(int[] inorder, int istart, int iend, int[] postorder, int pstart, int pend, Hashtable ht){
        if(istart > iend || pstart > pend)
            return null;
        
        var root = new TreeNode(postorder[pend]);
        var index = (int)ht[root.val];
        //left side of root
        var listart = istart;
        var liend = index - 1;
        var lpstart = pstart;
        var lpend = pstart + index - 1 - istart;
        //rigt side of root
        var ristart = index + 1;
        var riend = iend;
        var rpstart = pstart + index - istart;
        var rpend = pend - 1;
        
        root.left = BuildTreeRecursively(inorder, listart, liend, postorder, lpstart, lpend, ht);
        root.right = BuildTreeRecursively(inorder, ristart, riend, postorder, rpstart, rpend, ht);
        return root;
    }
}