/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution{
    public IList<int> Inorder(TreeNode root){
        var list = new List<int>();
        var st = new Stack<TreeNode>();
        while(true){
            while(root != null){
                st.Push(root);
                root = root.left;
            }
            if(st.Count == 0)
                break;
            root = st.Pop();
            list.Add(root.val);
            root = root.right;
        }
        return list;
    }
}