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