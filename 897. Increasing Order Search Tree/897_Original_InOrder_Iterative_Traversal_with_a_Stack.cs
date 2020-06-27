public class Solution {
    public TreeNode IncreasingBST(TreeNode root) {
        var inorder = new List<int>();
        //in-order traversal
        var st = new Stack<TreeNode>();
        while(true){
            while(root != null){
                st.Push(root);
                root = root.left;
            }
            if(st.Count == 0) break;
            root = st.Pop();
            inorder.Add(root.val);
            root = root.right;
        }
        root = new TreeNode(0);
        var cur = root;
        for(var i = 0; i < inorder.Count; ++i){
            cur.right = new TreeNode(inorder[i]); 
            cur = cur.right;
        }
        return root.right;
    }
}