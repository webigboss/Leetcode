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
    public void RecoverTree(TreeNode root) {
        var list = new List<TreeNode>();
        var swaplist = new TreeNode[2];
        TreeNode first = root;
        TreeNode second = root;
        var temp = 0;
        InorderTraversal(root, list, swaplist, false);
        InorderTraversal(root, list, swaplist, true);
        
        temp = swaplist[0].val;
        swaplist[0].val = swaplist[1].val;
        swaplist[1].val = temp;

    }
    
    private void InorderTraversal(TreeNode n, List<TreeNode> list, TreeNode[] swap, bool reverse){
        if(n == null)
            return;
        
        if(reverse)
            InorderTraversal(n.right, list, swap, reverse);
        else
            InorderTraversal(n.left, list, swap, reverse);
            
        if(list.Count > 0){

            if(reverse && n.val > list[list.Count - 1].val){
                swap[0] = n;
            }
            else if (!reverse && n.val < list[list.Count - 1].val){
                swap[1] = n;
            }
        }
        list.Add(n);
        
        if(reverse)
            InorderTraversal(n.left, list, swap, reverse);
        else
            InorderTraversal(n.right, list, swap, reverse);
    }
    
}
