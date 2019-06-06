/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

//!!!Note: there was no straight-forward interative solution for postoder traversal,
//however a regular postorder traversal equals to the reversal result of preorder right node first traversal (node > right > left)

public class Solution{
    public IList<int> Postorder(TreeNode root){
        var list = new List<int>();
        var st = new Stack<TreeNode>();

        while(true){
            while(root != null){
                list.Add(root.val);
                st.Push(root);
                root = root.right;
            }

            if(st.Count == 0)
                break;
            root = st.Pop();

            root = root.left;
        }
        list.Reverse();
        return list;      
    }
}