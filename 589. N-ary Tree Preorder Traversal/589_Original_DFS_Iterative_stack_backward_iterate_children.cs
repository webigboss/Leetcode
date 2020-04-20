public class Solution {
    public IList<int> Preorder(Node root) {
        //DFS interative appraoch with a stack
        //the only thing is the iteration order of adding children to the stack has to be backward from tail to head;
        //in this way to make sure the first child get popup and processed first;
        if(root == null) return new List<int>();
        var st = new Stack<Node>();
        var result = new List<int>();
        st.Push(root);
        while(st.Count > 0){
            var node = st.Pop();
            result.Add(node.val);
            for(var i = node.children.Count-1; i >= 0; --i)
                st.Push(node.children[i]);
        }
        return result;
    }
}