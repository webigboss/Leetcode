public class Solution {
    public IList<int> PostorderTraversal(TreeNode root) {
        //DFS iterative with stack, mirrored pre-order traverse then reverse the result;
        if(root == null) return new List<int>();
        var st = new Stack<TreeNode>();
        var list = new List<int>();
        st.Push(root);
        while(st.Count > 0){
            var node = st.Pop();
            list.Add(node.val);
            if(node.left != null)
                st.Push(node.left);
            if(node.right != null)
                st.Push(node.right);
        }
        list.Reverse();
        return list;
    }
}

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