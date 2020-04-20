public class Solution {
    public IList<int> Postorder(Node root) {
        //DFS iterative with a stack, mirrored the preorder and reverse the result
        // note we need to reversely push children nodes to the stack
        //for pre-order reverse, iteration need to go from the children.count - 1 to 0;
        //since we are now doing the mirrored pre-order, the order is from 0 to children.count - 1;
        if(root == null) return new List<int>();
        var st = new Stack<Node>();
        var result = new List<int>();
        st.Push(root);
        while(st.Count > 0){
            var node = st.Pop();
            result.Add(node.val);
            for(var i = 0; i < node.children.Count; ++i)
                st.Push(node.children[i]);   
        }
        result.Reverse();
        return result;
    }
}